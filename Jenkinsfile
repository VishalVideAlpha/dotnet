pipeline {
  agent { label 'dev' }  
  parameters {
    // Git (works for "Pipeline script" jobs)
    string(name: 'GIT_URL', defaultValue: 'https://github.com/VishalVideAlpha/dotnet.git', description: 'Git repo URL')
    string(name: 'GIT_BRANCH', defaultValue: 'main', description: 'main')
    string(name: 'GIT_CREDENTIALS_ID', defaultValue: '', description: 'Jenkins credentials ID (leave empty for public)')

    // Build/Container
