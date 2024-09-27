This document describes the running of the Wallet Application and the existing tests

Steps to run the Application (steps 1. and 2. are written in the original Task description too)

1. In directory qa-backend-code-challenge execute the following command :
   
   docker build -f src/Betsson.OnlineWallets.Web/Dockerfile .

2. After the build pricess, take the "image id" from the resultung printout and run the dockerized container

    docker run -p <port>:8080 <image id>

    Now the Application is running

3. The API testes are located in

   Betsson.OnlineWallets.Tests\APITTests.cs

   Operations "GetBalance", "Send money to Wallet", "Withdraw money" are targeted

   

   
