# 構建將主機目錄掛載到容器目錄的docker環境

## 1. 安裝docker
## 2. npm install
## 3. 撰寫 Dockerfile
## 4. .dockerignore 忽略
## 5. 創建images -> 執行container
- ### 常用docker指令: 單純使用cmdline
    - docker images (查看當前images)
    - docker ps [-a] (查看執行中container, -a: 顯示其他狀態的內容)
    - docker build [-t] . (使用當前目錄, 創建images, -t: 指定名稱tag)
    - docker rmi [-f] images (移除images: 指定id或名稱, -f: 強制, 不管有沒有在執行)
    - docker run -d -v D:\1.henry_stuff\My_project\dockerTest:/test:ro -v /test/node_modules -p 3000:3000 --name test test/nodejs:v1. (執行container)
    - docker rm [-fv] test (刪除container, -v: volumes)
    - docker exec -it test /bin/sh (使用終端機交互container)
- ### 常用docker指令: docker-compose.yml
    - docker-compose up -d --build (使用docker-compose.yml執行容器, -d: 背景執行, --build: 重建)
    - docker-compose down -v (清除)