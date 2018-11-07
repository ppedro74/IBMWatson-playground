# A playground to test and troubleshoot IBM Watson Services

## 1) IBMWatsonServicesTest
Visual Studio 2017 project:
.NET 4.6.1 WinForms Application
.NET IBM.WatsonDeveloperCloud.TextToSpeech.v1 (.NET Standard Library)

This statement does not work:

```
var service = new TextToSpeechService(tokenOptions);
```

generates the following exception:
```
System.Security.VerificationException: Method System.Net.Http.CloneableExtensions.Clone: type argument 'System.Net.Http.Headers.MediaTypeHeaderValue' violates the constraint of type parameter 'T'.
   at System.Net.Http.Formatting.MediaTypeConstants.get_ApplicationJsonMediaType()
   at System.Net.Http.Formatting.JsonMediaTypeFormatter..ctor()
   at System.Net.Http.Formatting.MediaTypeFormatterCollection.CreateDefaultFormatters()
   at IBM.WatsonDeveloperCloud.Http.WatsonHttpClient..ctor(String baseUri, String userName, String password)
   at IBM.WatsonDeveloperCloud.Service.WatsonService..ctor(String serviceName, String url)
   at IBM.WatsonDeveloperCloud.TextToSpeech.v1.TextToSpeechService..ctor()
   at IBM.WatsonDeveloperCloud.TextToSpeech.v1.TextToSpeechService..ctor(TokenOptions options)
   at IBMWatsonServicesTest.MainForm.SynthesizeButton_Click(Object sender, EventArgs e) in C:\dev\IBMWatson-playground\IBMWatsonServicesTest\MainForm.cs:line 117]
```

Is related to this issue: https://github.com/dotnet/corefx/issues/11100

 
### Workaround/Solution:

Step 1:
In /Project/PropertyGroup*1 (the first PropertyGroup element of Project), add the following line, or change the value of this element if it already exists: <AutoGenerateBindingRedirects>false</AutoGenerateBindingRedirects>

Step 2:
Open the app.config file for this project. Add a missing reference Newtonsoft.Json 6.0.0.0 (showing up after step1 is in place)
<runtime>
	<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
		<dependentAssembly>
			<assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
			<bindingRedirect oldVersion="0.0.0.0-11.0.0.0" newVersion="11.0.0.0" />
		</dependentAssembly>
	</assemblyBinding>
</runtime>

Voilà it works !!! Something simple becames an issue although not the best solution.