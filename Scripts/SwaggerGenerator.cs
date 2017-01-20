	public static class SwaggerGenerator
	{
		public static async Task Go ()
		{
			var swaggerJson = await "https://api.mobile.azure.com/preview/swagger.json".GetJsonFromUrlAsync ();

			var swaggerJsonObject = JsonObject.Parse (swaggerJson);

			var swaggerJsonArrayObjects = swaggerJsonObject.Object ("paths").ToDictionary (k => k.Key, v => JsonObject.Parse (v.Value).ToDictionary (kk => kk.Key, vv => JsonObject.Parse (vv.Value)));

			foreach (var path in swaggerJsonArrayObjects)
			{
				foreach (var operationObj in path.Value)
				{
					var operationId = operationObj.Value ["operationId"];

					if (!operationId.isValidOperationId ())
					{
						if (!operationId.IsNullOrEmpty ())
						{
							operationId = $"{getArea (operationObj).uppercaseFirstLetter ()}_{operationId.uppercaseFirstLetter ()}";
						}
						else
						{
							operationId = $"{getArea (operationObj).uppercaseFirstLetter ()}_{operationObj.Key.uppercaseFirstLetter ()}{urlPathToOperation (path.Key).uppercaseFirstLetter ()}";
						}
					}

					operationObj.Value ["operationId"] = operationId;
				}
			}

			//System.Diagnostics.Debug.WriteLine ($"{swaggerJsonArrayObjects.ToJson ()}");

			swaggerJsonObject ["paths"] = swaggerJsonArrayObjects.ToJson ();

			System.Diagnostics.Debug.WriteLine ($"{swaggerJsonObject.ToJson ()}");

		}

		static bool isValidOperationId (this string str) => str?.Contains ("_") ?? false;

		static string getArea (KeyValuePair<string, JsonObject> operationObj)
		{
			var tags = operationObj.Value.Object ("tags");

			return tags?.Keys?.FirstOrDefault () ?? "Misc";
		}

		static string urlPathToOperation (string urlPath)
		{
			return urlPath.Split ('/')
						  .Where (s => !s.IsNullOrEmpty () && !s.Contains ("."))
						  .Select (p => p.convertParameter ()
									  	 .removeIlleagalCharacters ()
										 .ToPascalCase ())
						  .Join (string.Empty);
		}

		static string removeIlleagalCharacters (this string str) => str.ReplaceAll (".", string.Empty);

		static string convertParameter (this string str) => (str.FirstOrDefault () == '{') ? $"By_{str.SafeSubstring (1, str.Length - 2)}" : str;

		static string uppercaseFirstLetter (this string str) => $"{str.FirstOrDefault ().ToInvariantUpper ()}{str.SafeSubstring (1)}";
	}
