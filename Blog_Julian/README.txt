<!DOCTYPE html>
<html>
<head>
    <title></title>
	<meta charset="utf-8" />
</head>

<body>
		<h3> Rich Text Field Posts <h3>
		<p> In package manager:		Install-Package TinyMCE.MVC.JQuery
			
			Add JQuery.Min to tinymce_jquery_full.cshtml in /Shared/EditorTemplates
			Move Jquery Render to the top of /Shared/Layout.cshtml, it's currently located at the bottom of the script

			Add JQuery Validate Bundle To /Shared/Layout.cshtml as @Scripts.Render("~/bundles/jqueryval")


			For more inforamtion:	https://www.youtube.com/watch?v=b4-3CAQVwW8
		</p>
</body>
</html>
