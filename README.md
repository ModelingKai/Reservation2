![.github/workflows/main.yml](https://github.com/ModelingKai/Reservation2/workflows/.github/workflows/main.yml/badge.svg)

# web application を heroku へデプロイする


## 事前準備

- Heroku上にアプリを作成する
    - https://dashboard.heroku.com/new-app
    - アプリ名を控えておく
    
 - dotnet cli をダウンロードする
    - https://devcenter.heroku.com/articles/heroku-cli#download-and-install
    
## デプロイ

ルートディレクトリで、以下のスクリプトを実行。

```bash
./deploy_to_heroku.sh <heroku_app_name>     
```
