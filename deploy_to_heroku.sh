#!/bin/bash

if [ -z "$1" ]; then
  echo "herokuのアプリ名を入力してください。" 
  exit 1
fi
APP_NAME=$1

# DockerFile copy
yes | cp WebApplication/Dockerfile WebApplication/bin/Release/netcoreapp3.1/publish/Dockerfile

# publish
( cd WebApplication/ && dotnet publish -c Release )
if [ ${PIPESTATUS[@]} -ne 0 ]; then
  echo "publishでエラーが起きました。" 
  exit 1
fi
# herokuコンテナへpush
(cd WebApplication/bin/Release/netcoreapp3.1/publish && heroku container:push web -a ${APP_NAME})   
if [ ${PIPESTATUS[@]} -ne 0 ]; then
  echo "herokuコンテナへpushでエラーが起きました。"
  exit 1
fi

# pushしたソースコードを展開
(cd WebApplication/bin/Release/netcoreapp3.1/publish && heroku container:release web -a ${APP_NAME})   
if [ ${PIPESTATUS[@]} -ne 0 ]; then
  echo "herokuコンテナのreleaseでエラーが起きました。"
  exit 1
fi

echo "herokuへのリリースが完了しました。"
echo " (cd WebApplication/bin/Release/netcoreapp3.1/publish && heroku open -a ${APP_NAME}) でアプリが開きます。"

