pipeline {
    agent { label 'ubuntu' }

    environment {
        PUBLISH_DIR = "/var/YogaMasterskyaMVC/publish"
        SERVICE_NAME = "yogamasterskya.mvc"
    }

    stages {
        stage('Checkout') {
            steps {
                // Подтягиваем код из репозитория
                checkout scm
            }
        }

        stage('Build and Publish') {
            steps {
                script {
                    // Убедимся, что папка для публикации существует
                    sh "mkdir -p ${PUBLISH_DIR}"
                    // Сборка и публикация
                    sh "dotnet publish -c Release -o ${PUBLISH_DIR}"
                }
            }
        }

        stage('Restart Service') {
            steps {
                script {
                    // Останавливаем службу
                    sh "sudo systemctl stop ${SERVICE_NAME}"
                    // Небольшая пауза для корректного завершения (опционально)
                    sh "sleep 5"
                    // Запускаем службу
                    sh "sudo systemctl start ${SERVICE_NAME}"
                }
            }
        }
    }

    post {
        success {
            echo "Deployment completed successfully."
        }
        failure {
            echo "Deployment failed."
        }
    }
}
