#Prompt:  create a bash script to rename files in a directory with the creation date appended to the filename


$directory = "C:\path\to\directory"

Get-ChildItem -Path $directory | ForEach-Object {
    $newName = $_.BaseName + "_" + $_.CreationTime.ToString("yyyyMMdd") + $_.Extension
    Rename-Item -Path $_.FullName -NewName $newName
}
