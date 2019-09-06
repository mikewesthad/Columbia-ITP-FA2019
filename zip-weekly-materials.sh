#!/bin/bash

# Script to run zipping through git, effectively applying .gitignore to the zip. Files must be
# commited before running.

for dir in Weekly\ Materials/*/ ; do
	folderpath=${dir%/} # Strip trailing slash
  git archive --format=zip -o "$folderpath.zip" HEAD:"$dir"
done