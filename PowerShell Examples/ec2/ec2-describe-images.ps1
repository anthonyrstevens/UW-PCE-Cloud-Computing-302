# look at images in the us-west-1 region whose platform contains "windows"
ec2-describe-images --region us-west-1 --filter "`"platform=windows`""