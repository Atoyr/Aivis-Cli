# Aivis CLI

[日本語](#日本語) | [English](#english)

---

## 日本語

Aivis.Netを使用したテキスト読み上げ用のコマンドラインインターフェースツールです。

### 機能

- Aivis APIを使用したテキスト音声合成
- コマンドラインからの直接音声再生
- シンプルで軽量なCLIインターフェース
- クロスプラットフォーム対応（.NET 9.0）

### インストール

#### リリースからダウンロード

1. [Releasesページ](https://github.com/atoyr/Aivis-Cli/releases)からお使いのプラットフォーム用の最新リリースをダウンロード
2. アーカイブを任意の場所に展開
3. 実行ファイルをPATHに追加（以下を参照）

#### ソースからビルド

```bash
git clone https://github.com/atoyr/Aivis-Cli.git
cd Aivis-Cli
dotnet build -c Release
```

### PATHへの追加

どこからでも `aivis` を実行できるようにするため、実行ファイルをシステムPATHに追加してください：

#### Windows
1. `aivis.exe` を永続的な場所に移動（例：`C:\Tools\aivis\`）
2. ディレクトリをPATHに追加：
   - システムのプロパティから「環境変数」を開く
   - システム環境変数の「Path」を編集
   - ディレクトリパス（例：`C:\Tools\aivis\`）を追加
   - ターミナルを再起動

PowerShellを使用する場合：
```powershell
# 現在のセッションのみ
$env:PATH += ";C:\path\to\aivis\directory"

# 永続的に追加（管理者権限が必要）
[Environment]::SetEnvironmentVariable("Path", $env:Path + ";C:\path\to\aivis\directory", "Machine")
```

#### Linux/macOS
1. `aivis` 実行ファイルをPATH内のディレクトリに移動：
```bash
# オプション1：/usr/local/binに移動（sudoが必要）
sudo mv aivis /usr/local/bin/

# オプション2：~/.local/binに移動（ユーザー固有）
mkdir -p ~/.local/bin
mv aivis ~/.local/bin/
echo 'export PATH="$HOME/.local/bin:$PATH"' >> ~/.bashrc
source ~/.bashrc

# オプション3：シンボリックリンクを作成
sudo ln -s /path/to/aivis /usr/local/bin/aivis
```

2. 実行権限を設定：
```bash
chmod +x aivis
```

#### インストール確認
```bash
aivis --version
```

### セットアップ

Aivis CLIを使用する前に、必要な環境変数を設定してください：

```bash
export AIVIS_API_KEY="your_api_key_here"
export AIVIS_MODEL_ID="your_model_id_here"
```

Windows（PowerShell）の場合：
```powershell
$env:AIVIS_API_KEY="your_api_key_here"
$env:AIVIS_MODEL_ID="your_model_id_here"
```

### 使い方

```bash
aivis "こんにちは、世界！"
```

ツールはAivis APIを使用して提供されたテキストを音声合成し、生成された音声を再生します。

#### 使用例

```bash
# シンプルなテキスト合成
aivis "こんにちは、世界！"

# 複数の単語
aivis "これはテキスト読み上げ合成のための長い文章です。"

# バージョン確認
aivis --version
```

### 動作要件

- .NET 9.0 ランタイム
- 有効なAivis APIキーとモデルID
- 音声出力デバイス

### 依存関係

- [Aivis.Net](https://www.nuget.org/packages/Aivis.Net/) v0.5.0

### エラーハンドリング

アプリケーションは一般的な問題に対して分かりやすいエラーメッセージを表示します：

- コマンドライン引数の不足
- 環境変数の不足（AIVIS_API_KEY、AIVIS_MODEL_ID）
- API接続の問題

### コントリビューション

1. リポジトリをフォーク
2. フィーチャーブランチを作成（`git checkout -b feature/amazing-feature`）
3. 変更をコミット（`git commit -m 'Add some amazing feature'`）
4. ブランチにプッシュ（`git push origin feature/amazing-feature`）
5. プルリクエストを開く

### ライセンス

このプロジェクトはMITライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルを参照してください。

### サポート

問題が発生した場合や質問がある場合は、GitHubで[issue](https://github.com/atoyr/Aivis-Cli/issues)を開いてください。

---

## English

A command-line interface tool for text-to-speech synthesis using Aivis.Net.

### Features

- Convert text to speech using Aivis API
- Direct audio playback through command line
- Simple and lightweight CLI interface
- Cross-platform support (.NET 9.0)

### Installation

#### Download from Releases

1. Download the latest release for your platform from the [Releases page](https://github.com/atoyr/Aivis-Cli/releases)
2. Extract the archive to your preferred location
3. Add the executable to your PATH (see below)

#### Build from Source

```bash
git clone https://github.com/atoyr/Aivis-Cli.git
cd Aivis-Cli
dotnet build -c Release
```

### Adding to PATH

To run `aivis` from anywhere in your terminal, add the executable to your system PATH:

#### Windows
1. Move `aivis.exe` to a permanent location (e.g., `C:\Tools\aivis\`)
2. Add the directory to your PATH:
   - Open "Environment Variables" from System Properties
   - Edit the "Path" variable in System Variables
   - Add the directory path (e.g., `C:\Tools\aivis\`)
   - Restart your terminal

Or use PowerShell:
```powershell
# Add to current session
$env:PATH += ";C:\path\to\aivis\directory"

# Add permanently (requires admin)
[Environment]::SetEnvironmentVariable("Path", $env:Path + ";C:\path\to\aivis\directory", "Machine")
```

#### Linux/macOS
1. Move the `aivis` executable to a directory in your PATH:
```bash
# Option 1: Move to /usr/local/bin (requires sudo)
sudo mv aivis /usr/local/bin/

# Option 2: Move to ~/.local/bin (user-specific)
mkdir -p ~/.local/bin
mv aivis ~/.local/bin/
echo 'export PATH="$HOME/.local/bin:$PATH"' >> ~/.bashrc
source ~/.bashrc

# Option 3: Create a symbolic link
sudo ln -s /path/to/aivis /usr/local/bin/aivis
```

2. Make sure the executable has the right permissions:
```bash
chmod +x aivis
```

#### Verify Installation
```bash
aivis --version
```

### Setup

Before using Aivis CLI, you need to set up the required environment variables:

```bash
export AIVIS_API_KEY="your_api_key_here"
export AIVIS_MODEL_ID="your_model_id_here"
```

On Windows (PowerShell):
```powershell
$env:AIVIS_API_KEY="your_api_key_here"
$env:AIVIS_MODEL_ID="your_model_id_here"
```

### Usage

```bash
aivis "Hello, world!"
```

The tool will synthesize the provided text using the Aivis API and play the generated audio.

#### Examples

```bash
# Simple text synthesis
aivis "Hello, world!"

# Multi-word text
aivis "This is a longer sentence for text-to-speech synthesis."

# Check version
aivis --version
```

### Requirements

- .NET 9.0 Runtime
- Valid Aivis API key and model ID
- Audio output device

### Dependencies

- [Aivis.Net](https://www.nuget.org/packages/Aivis.Net/) v0.5.0

### Error Handling

The application will display helpful error messages for common issues:

- Missing command line arguments
- Missing environment variables (AIVIS_API_KEY, AIVIS_MODEL_ID)
- API connection issues

### Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

### Support

If you encounter any issues or have questions, please [open an issue](https://github.com/atoyr/Aivis-Cli/issues) on GitHub.