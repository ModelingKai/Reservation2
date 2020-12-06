# 1. リポジトリのインターフェースをUseCase層に置く

Date: 2020-12-07

## ステータス(Status)

Accepted

## コンテキスト(Context)

予約をする、というユースケースを実装するにあたり、Repositoryのインターフェース定義が必要になった。
前回（Reservation1）の方では、Domain層にインターフェースを置いていた

## 決定(Decision)

リポジトリは、外界とのやり取りをするものであり、ドメイン層の持ち物では無いという考え方。
それに基づき、外界とのやり取りをするものはUseCase層に置いた方が良いだろうという判断。

## 結果(Consequences)

UseCase層にRepositoryInterfacesというディレクトリを切る。
その中に、I予約Repositoryインターフェースを用意する。

