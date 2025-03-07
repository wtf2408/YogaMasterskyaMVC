pipeline {
    agent { label 'ubuntu' }

    environment {
        PUBLISH_DIR = "/var/YogaMasterskyaMVC/publish"
        SERVICE_NAME = "yogamasterskya.mvc"
    }

    stages {
        stage('Checkout') {
            steps {
                // ����������� ��� �� �����������
                checkout scm
            }
        }

        stage('Build and Publish') {
            steps {
                script {
                    // ��������, ��� ����� ��� ���������� ����������
                    sh "mkdir -p ${PUBLISH_DIR}"
                    // ������ � ����������
                    sh "dotnet publish -c Release -o ${PUBLISH_DIR}"
                }
            }
        }

        stage('Restart Service') {
            steps {
                script {
                    // ������������� ������
                    sh "sudo systemctl stop ${SERVICE_NAME}"
                    // ��������� ����� ��� ����������� ���������� (�����������)
                    sh "sleep 5"
                    // ��������� ������
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
