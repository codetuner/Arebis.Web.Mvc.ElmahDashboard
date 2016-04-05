param($rootPath, $toolsPath, $package, $project)

if ($project) {
	$projectDestinationPath = Split-Path $project.FullName -Parent
	if(Test-Path $projectDestinationPath) {
		$DTE.ItemOperations.Navigate($projectDestinationPath + '\MvcElmahDashboard_Readme.html')
	}
}