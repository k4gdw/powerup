@ECHO OFF
REM Build.bat
REM Created by:  Bryan Johns
REM Copyright:	 K4GDW Software 2012

IF NOT "%1"=="" (
	IF "%1"=="/build" (
		IF NOT "%2"=="" (
			SET build=%2
			msbuild.exe build.msbuild /t:Publish /p:BuildNo=%build%;LocalBuild=True /m
		) ELSE (
			ECHO You must supply a build number.
		)
	)
) ELSE (
	msbuild build.msbuild /t:Publish /p:LocalBuild=True /m
)
