# Post-migration assessment

**Controller status: Failed; acceptance: NotRun; stop: BaselineBroken.**
Required checks: 0/124 passed; 0 failed; 0 blocked; 124 not run.
Finalization: sealed.
Required checks: 0/124 passed; 0 failed; 0 blocked; 124 not run. Acceptance: NotRun. Execution stop: BaselineBroken. Execution detail: The source does not build before migration: 24 of 24 error(s) are the application's own (CS0234, CS0246). Nothing was changed. Fix the source and run again, or pass --skip-baseline to migrate it anyway.

## Reviewed package source configuration

Destination: `nuget.config`; SHA-256: `8ae8d19e861e4e2ab78ea9ea61cecbc420ba90278c5c602b87d0313348cde6c0`.
Proposal origin: `C:\Users\raghavmadan\.copilot\session-state\52f15054-86e8-4212-b97b-e50be2b17a1f\files\calculator-review\proposed-nuget.config`. The assessment contains the immutable configuration; the origin is not reread during execution.
Source declarations, disabled-source settings and mappings replace inherited source policy. Review every source and pattern. No credentials are embedded.
- nuget.org: `https://api.nuget.org/v3/index.json`; packages: none.
- azure-default: `https://packagefeedproxy.microsoft.io/nuget/v3/index.json`; packages: *.
After approval, the checked configuration action applies these bytes and records its patch. Feed lookup does not establish a complete application restore.
Actual application status is recorded in the required package-configuration checks and action attempts.
The working database is authoritative. Without a verified sibling manifest, a repository bundle and its reports are uncommitted candidates, not completed provenance.

## Run, task and input identity
Run: `run-20261112-114328-af03e6`; task: `01d4dc2cd28c409bababcba9fe4c0ab9`; replay: `none`.
Continued from: `none`. Continued runs preserve prior attempts, rechecks and the complete original check inventory.
Assessment: `01d4dc2cd28c409bababcba9fe4c0ab9`, revision 2; hash `806679bc0bf2ffc13dde5e04a74c306671ba07a240baa330f5f95c05b3bdccb5`.
Immutable pre-assessment: `C:\phase2\calculator-winui3\.winui-migrate\runs\run-20261112-114328-af03e6\assessment\assessment.json` (not embedded in this report).
Source commit: `1ad72a0225153cbe36b237dbfc96193277d3f618`; dirty at assessment: True.
Approved input: `92fb163850e2dbfe71179bfdd2d58627192d8b0a018f30ae3e811000c0d2318c`; final input: `92fb163850e2dbfe71179bfdd2d58627192d8b0a018f30ae3e811000c0d2318c`.
UTC execution started: 2026-11-12T11:43:28.9924322+00:00; execution completed: 2026-11-12T11:44:24.7774736+00:00.
Monotonic execution duration: 55799 ms. Finalization began: 2026-11-12T11:44:24.7775116+00:00.
For a sealed repository run, finalization duration and publication-prepared UTC are in the verified manifest. They exclude only writing/publishing that commit marker and are not part of the execution duration.

## Component versions and provenance
| Kind / component | Version | Hash | Observation / source |
| --- | --- | --- | --- |
| evaluator/package-configuration | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.PackageConfigurationEvaluator |
| evaluator/retarget | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.RetargetEvaluator |
| evaluator/runtime-compatibility | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.RuntimeCompatibilityEvaluator |
| evaluator/test-host-compatibility | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.TestHostCompatibilityEvaluator |
| evaluator/windowing-compatibility | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.WindowingCompatibilityEvaluator |
| evaluator/prepare-environment | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.WinAppEnvironmentEvaluator |
| evaluator/build | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.BuildEvaluator |
| evaluator/launch | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.LaunchEvaluator |
| evaluator/package | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.WinAppPackageEvaluator |
| evaluator/sign-package | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.WinAppSignEvaluator |
| evaluator/install-signed-package | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.WinAppSignedInstallEvaluator |
| evaluator/test | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.TestEvaluator |
| evaluator/smoke-test | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.SmokeTestEvaluator |
| harness/WinUI.Migrate.Platform.Orchestrator | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | 5e7a603852b1425bbfce611e3b9edb59 | configured; WinUI.Migrate.Platform.Orchestrator.MigrationOrchestrator |
| controller-policy/WinUI.Migrate.Platform.Orchestrator | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | 5e7a603852b1425bbfce611e3b9edb59 | configured; WinUI.Migrate.Platform.Orchestrator.RunContractBuilder |
| infrastructure/WinUI.Migrate.Platform.Infrastructure | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | 133de0f45c6b4243a0a6268fbaa12994 | configured; WinUI.Migrate.Platform.Infrastructure.Eval.Preflight |
| migration-pack/uwp | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | 288984956bbb4444bd3a83544393106c | configured; WinUI.Migrate.Packs.Uwp.UwpMigrationPack |
| planner/WinUI.Migrate.Platform.Planning | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | 5d7cc721fe2d48b3bb4f122c8e38f99e | configured; WinUI.Migrate.Platform.Planning.BuildRepairPlanner |
| storage/WinUI.Migrate.Platform.Storage | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | aad7d5d823794812ba89ceb3dc66d996 | configured; WinUI.Migrate.Platform.Storage.SqliteMigrationStore |
| rules-store/WinUI.Migrate.Platform.Planning | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | 5d7cc721fe2d48b3bb4f122c8e38f99e | configured; WinUI.Migrate.Platform.Planning.Rules.DictionaryRulesStore |
| evaluation-suite/uwp-eval-manifests | content-v1 | 83bfeb7da5e57b5089b7ed296bfa5410878b4fce2e1887055cdc46463b798a9c | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals |
| evaluation-suite/uwp-required-checks | content-v1 | 8e6519a03becbcf70082cb90491f02678f7656a5dec95c02c47fcbf9a45343d9 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals |
| evaluation-definition/eval.json | not reported | 2eaafdf2ac9672fc6757f5f50dab3ec870ee83740871568e99819df7910b2779 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\build\eval.json |
| evaluation-definition/eval.json | not reported | 47b28dbe6d95295556dd19d71472ea37cb052703c125f05465a2bb9c7d26c48c | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-01\eval.json |
| evaluation-definition/eval.json | not reported | f63d400b9d728c883965e341d5596f9a72a6fefa6e457d020718ed4e95fb4bf6 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-02\eval.json |
| evaluation-definition/eval.json | not reported | 5bebddaef2fdb5ba0c95e5575406c724dda1b359c4101c43fb60eef85866da97 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-03\eval.json |
| evaluation-definition/eval.json | not reported | 7811b7a32f36c78d345f4e3acc8c76ef4dde9863a30e631540ab661b1eace6c5 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-04\eval.json |
| evaluation-definition/eval.json | not reported | 18313e1a5db0e58408b4648f2e1f575e7c962145b99d3747939b10744af82f2b | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-05\eval.json |
| evaluation-definition/eval.json | not reported | 7f870d444fea0ca1a9b3e05ccee722bd41354c933ece351b55288e5cac8dc79d | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-06\eval.json |
| evaluation-definition/eval.json | not reported | 25afa91cce88499b06d03a84cd473243ca212973ba3276b827ca8d3227d6d205 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-07\eval.json |
| evaluation-definition/eval.json | not reported | d24514717c79663d15a54517dcb82753276dfb2def5aeb8364b68fe17bcb0c00 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-08\eval.json |
| evaluation-definition/eval.json | not reported | 99ef8ad9d1208fd76522bb9088dda120f79081d58a992d20ad33f5ba226ce951 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-09\eval.json |
| evaluation-definition/eval.json | not reported | 931d7564b61e341d8875c820eaf7310b452ad45fca9a7db207144408a4fda22a | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-10\eval.json |
| evaluation-definition/eval.json | not reported | d71ce97008072e67692b077c1d70bb5943c242fc6f405cc6c1046e988b85c733 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-11\eval.json |
| evaluation-definition/eval.json | not reported | 97c0b29feaad0cadf622268ccd10682abaef7de4843d1539da9e09945c648aca | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-12\eval.json |
| evaluation-definition/eval.json | not reported | dcd0828f5ec72c71799249da89ee371fc4eeab2eef2b333e49d746e8c721075f | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-13\eval.json |
| evaluation-definition/eval.json | not reported | 04a8402aab10f060acd63a3750117364d27e848436b94a08af0b5e20d1607363 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\eval-14\eval.json |
| evaluation-definition/eval.json | not reported | 2666f0b9b0a750407c17cae6e30e27527563fe2ec5fed38146d654692f29a38c | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\launch\eval.json |
| evaluation-definition/eval.json | not reported | 1ba55e7583bfd6a247d3dfa61eaf33dc3ac7542ebaab2415432dff05c2446ffd | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\package-configuration\eval.json |
| evaluation-definition/eval.json | not reported | 638f80bea1a742c3a2c532fe317b328c9ed660bee8bf5a9b615fb236bd6f9409 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\pre-migration\eval.json |
| evaluation-definition/eval.json | not reported | 6406d15577a8575cf5683466bde5aea8ed7939200c53c22b047dd561e2e0e1bc | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\retarget\eval.json |
| evaluation-definition/eval.json | not reported | 5fd59fff4558f094ff03719d6c8e1fa63a14cfdd23cde3b9a154be3ad4d54f01 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\runtime-compatibility\eval.json |
| evaluation-definition/eval.json | not reported | 4acab8db3ea7f44be9850ddd0cf7d9e464c5915677ac52f2142f91065b9f5a03 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\smoke-test\eval.json |
| evaluation-definition/eval.json | not reported | 3e1ad46760ca855508cf484d3df4d3473da62fcc444458d2a4e76b10a9af4ef4 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\test-host-compatibility\eval.json |
| evaluation-definition/eval.json | not reported | 5909d5ac62a59f1b905f99547b8909f454ea03fbcb8fcc570a3de8d95fa1b8ff | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\test\eval.json |
| evaluation-definition/eval.json | not reported | 3287759069a93aefa19fc9b160857cf3ff68ac7ceaf85670534de6a720f99555 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\windowing-compatibility\eval.json |
| evaluation-definition/launch-packaged-app.ps1 | not reported | 1252c6447c592c3bf8f237aeada6d945c916323d909910e4ec9764208c1a1d6c | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\packs\uwp\evals\launch\launch-packaged-app.ps1 |
| evaluation-definition/decision-alternatives.tsv | not reported | 082ab65141a5d76f168916c03f502ddbe158e3defaeba85c271bfb801ae69b63 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\decision-alternatives.tsv |
| evaluation-definition/dependency-rules.tsv | not reported | 0ca7722515a2bd047b9100c1fcbe58ea795ee237098b5748e3abc16ccbc2a367 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\dependency-rules.tsv |
| evaluation-definition/native-interop-rules.tsv | not reported | 5c82e965ddc94d40c579ddaee0e44eab04983906df7630ee239649fa3a10396a | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\native-interop-rules.tsv |
| evaluation-definition/runtime-paths.tsv | not reported | ac4a87176a826b832ce0665c418861c27bcda8f434de9d28e49e576fbb73e78e | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\runtime-paths.tsv |
| evaluation-definition/signals.tsv | not reported | 70f46f1f8e2c5b2c5cd704eaa695508b5f393a04155e5e5a079ce11c1e64965e | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\signals.tsv |
| evaluation-definition/builder-present.yaml | not reported | 9f3c0edb4928ed8eab21773da0fac12a90d64d357c310ca9dd04032f95bf584f | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\builder-present.yaml |
| evaluation-definition/builder-version-supports-sdk.yaml | not reported | 390378f437bb57accb53d1a19308fbe8cc6247229c859fdc887af42aa682ade5 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\builder-version-supports-sdk.yaml |
| evaluation-definition/correct-builder-for-this-solution.yaml | not reported | 7bdfafdc78b9d041e1e9d09f023e7ee3dccb94d58bfc3cd7596ac1e111c57d41 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\correct-builder-for-this-solution.yaml |
| evaluation-definition/developer-mode.yaml | not reported | 3fe9e54d1dc6e9b74164599597d390e0be801940436e5b349e79ecdc7b38d5f4 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\developer-mode.yaml |
| evaluation-definition/feed-authentication.yaml | not reported | f714a467a50ae4c80e08d7f7b099fb83473ef1517ecddf7ffe3fafa4d61a52fe | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\feed-authentication.yaml |
| evaluation-definition/platform-exists.yaml | not reported | ab65c2a06a0f555d7b185e9ab3faa65dffeef77928f0d0fdcb1039d13cdb53b4 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\platform-exists.yaml |
| evaluation-definition/script-execution-allowed.yaml | not reported | 1d8380d066f291c00cefd7da88d0b3d7216014039c68c0764a2d2da33a3a3816 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\script-execution-allowed.yaml |
| evaluation-definition/sdk-pinned-by-global-json.yaml | not reported | 0f844d5c86f34963dbf7ff0579ade05b4dd872c76eea852244ad760661f3a74b | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\sdk-pinned-by-global-json.yaml |
| evaluation-definition/signing-certificate.yaml | not reported | 883c538fc7f7993b917fa285e99ea5e6789491c91bdc2def5b5d62de3dfd7f4d | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\signing-certificate.yaml |
| evaluation-definition/_schema.yaml | not reported | 93b6fe39a5db2dfe858e023c9c8116ed7784ed52a2f1bf1ad65ffc86207c3b02 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\checks\_schema.yaml |
| evaluation-definition/schema.yaml | not reported | 33e7220dfc6f780426909267be9c36e9e756d0b6d7d69848c77267c8e759b888 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\findings\schema.yaml |
| evaluation-definition/execute.yaml | not reported | bc075f7b37ab1d3e070e8a872a67468fe043bf9913c429b786f2e30ac9724024 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\protocol\execute.yaml |
| evaluation-definition/catalog.yaml | not reported | 894e18b302f90c610ef66e2e4c0cead5dd6c417ead7bdf9e99ba1a0b968ca1c0 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\requirements\catalog.yaml |
| evaluation-definition/app-model.yaml | not reported | 551e4355e35c2e6e1b1fbfbd9f8572e8006d7cf1bca0d7b6436dd1f5ce108a38 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\app-model.yaml |
| evaluation-definition/automation-status.yaml | not reported | fef989926251e5f06abc55dec0cecd4e97e94f7bfd4faeb8eb6a7cbf1d35f529 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\automation-status.yaml |
| evaluation-definition/detect-framework.yaml | not reported | 44c0715bb310db6d592f0b96d84334bbc34bd3c780d175213e2df92966bcbf13 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\detect-framework.yaml |
| evaluation-definition/environment-requirements.yaml | not reported | 0c923ee21b3d3492d1223a6fb435eda28d05e5074768524f597006c2ddcf14f1 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\environment-requirements.yaml |
| evaluation-definition/inventory-projects.yaml | not reported | a09ae816298cfca59c02931a2d1e5d65ae7a3d8eaefe9269a4535c5fa5fae431 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\inventory-projects.yaml |
| evaluation-definition/known-ports.yaml | not reported | 4cbe96246aa6e5b328cbf66e7ed48e1fe38a2742e65dc0c1ace4b6f7c93eb21a | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\known-ports.yaml |
| evaluation-definition/preflight.yaml | not reported | 05686a70e0b1edb34b10f1993730c9375a7f7ef1f5f977953b859d11ecbaa770 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\preflight.yaml |
| evaluation-definition/report.yaml | not reported | a4d983e79913d511255fc7433954d65542dbb215a11dd729c58023b5f3134be9 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\report.yaml |
| evaluation-definition/resolve-model.yaml | not reported | 7152dc700869cf5648ced1a67c5390009eba53a16497bde3cc40ad8abd5b5e09 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\resolve-model.yaml |
| evaluation-definition/resources.yaml | not reported | 789923c052fe78e46bf8e722334deccd618670844bbb52a3fbcbf709d7ebf498 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\resources.yaml |
| evaluation-definition/run-log.yaml | not reported | fa89a108f09bdb33b336051395d28c2dc20dee4fd07924d4f86303c3ca207cda | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\run-log.yaml |
| evaluation-definition/run-record.yaml | not reported | bd8e9025aa08995e75d4efe0899bde539f4809a2187fd665afb1ee0ba059772f | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\run-record.yaml |
| evaluation-definition/scan-packages.yaml | not reported | cff89ce43be4899e514857a2e696cff5216aa8443b8946373ef7b7f0ca8524b7 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\scan-packages.yaml |
| evaluation-definition/scoring.yaml | not reported | 9921f5a1ec78eb8f235a711fc489fba1bb1f26947e600eec6c02b11414774e6c | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\rules\scoring.yaml |
| evaluation-definition/acquire-repo.yaml | not reported | 56629c2266f9939da1f42fedc7a54506eddc0cdba87040f356a6e27627415c08 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\acquire-repo.yaml |
| evaluation-definition/build-project.yaml | not reported | 475ba451cc40418fae7c6f42853e4a8c5d53cd0d29c8b21f0d3fbabdc6f07d56 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\build-project.yaml |
| evaluation-definition/install-signed-package.yaml | not reported | 4eb158268db34ebd5d92779028f397322763b0aeafdc47a97c4b52e44ec09800 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\install-signed-package.yaml |
| evaluation-definition/launch-app.yaml | not reported | 90254188a18ced0cef3a470976218a1dd921524f6899c46d3006a5342a3d60c9 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\launch-app.yaml |
| evaluation-definition/migrate.yaml | not reported | 5e8967ed3066cd1797752b6035b29f6dca4660c237d2677c4dc96cfe18166ba0 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\migrate.yaml |
| evaluation-definition/package-app.yaml | not reported | f468c05dea061497baad43e81209130d1e07fde8d4bacd8a94812258264091c2 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\package-app.yaml |
| evaluation-definition/prepare-environment.yaml | not reported | c7abdda56bd113de73b6c124b9eca17219f775771a44a5eb9abb4eddb0d36419 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\prepare-environment.yaml |
| evaluation-definition/restore-project.yaml | not reported | 89b30722e40db04b31dd1c13e4c335402d5ee3f8eb5bfc2aec63f397f68a6d82 | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\restore-project.yaml |
| evaluation-definition/sign-package.yaml | not reported | 7d31dfca94dbf22d6343cb7629ad2a8c01921aaf8d4ec1e20763d6af172779ed | configured; C:\phase2\winui-tools\winui-migrate\dist\cli\skills\winui2-to-winui3-migration-eval\tasks\sign-package.yaml |
| dictionary/loaded-rule-content | content-v1 | 22acf755e3603533a19359e2ad922320698d013203088e639871543237571e16 | loaded; resolved package pins are recorded separately; [{"Folder":{"Path":"C:\\phase2\\winui-tools\\winui-migrate\\dist\\cli\\dictionary","Source":1},"Exists":true,"Entries":107,"Renames":79}] |
| guide/enumerate-tests | 0.2.4 | 2869049695348cb2bc28cb043235d30b0fef09d4c1b2369ef73dd49a95b0b70f | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/migrate | 0.2.4 | bf27a08233a57fbefe810ee1d166212f65a6ee1515db9eea2bccf843224107ab | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/migration-report | 0.2.4 | 3f83e5480b48e670a3f7b7add9998bbf3e2868b0fb921092c8900c35be164c90 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/pre-migration-harness-setup | 0.2.4 | 4a9c5531bd5f4758a32d30113cde84a3129d7d05a0fe658093d3f2a1cc31e8d1 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-activation | 0.2.4 | 4a53371c0b173eb37d82ca78419469e7c8f943997385ff32bacb109051c46145 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-ambiguous-namespace-check | 0.2.4 | 5fd63a7ea86ce1e8d83f2c6ed09e685cf656bc1dd0e1121291b255866ab0f774 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-app-entry-and-instancing | 0.2.4 | 52066cd716f335f14a5e6b3e8ef689806c988cf0b863db7062a40a190d975450 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-audio-frame-output | 0.2.4 | 25b92efc4523ba162340af5b503857e29989f7c83833ab65931ad7078fdaf771 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-control-parity-triage | 0.2.4 | d419055f552a3a143f46311d675c55af675158d415a78e00c87670d19048e718 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-dialogs-and-popups | 0.2.4 | dfa7a512311bd72a8e8f60619292d64f9f1a2a41f3b0dd3671d58feeeabe2041 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-dispatcher | 0.2.4 | 120d828f60f517f0c07e4a8a3f2e3305f87dc893bd3fcdb11b9de96ecfba8dc0 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-hwnd-interop | 0.2.4 | 9efba5fc5bdd33ac42f612507533fc38449129753bc50765e06811e087ae6e0b | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-lifecycle | 0.2.4 | 59499b2afe95ad8f9c0a9ce727f99c5233d1e1e1bc9e8c8f3b1ab2f1c2f36dff | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-migration-eval | 0.2.4 | 7794ac5f95058cab8fd4222412ccff937bcabf49d95471f7d2a1e4ceef76b3a1 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-migration-order | 0.2.4 | 04d868a07462beba18c3ae55a31103f1f8ce58d1fe6d6fe021ccda2ef115b910 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-namespace-replacement | 0.2.4 | b3e30037d732d56e73ca6d62090d3fd7f92e55de16cc9512af0f25765be44ac8 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-no-replacement-triage | 0.2.4 | fa8b503d7cf4f485ab49ae81a8e563109e5b2ffc210253f5cbe628e0391ba2b5 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-notifications | 0.2.4 | 1fe746d3ef3962be22fe8d5711d67690cd0975069a55eb1dad77c991f4fc197b | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-packaging-and-identity | 0.2.4 | a8d2c73a2f6e33f248322074b2ba1cf4151192596b61ed80a7124c76f90b494a | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-resources-and-theming | 0.2.4 | 992f1603d7180568b4485f3f7fab276ac3bf1dcebdf7c81c1ecb2fbbc1806ff2 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-test-host | 0.2.4 | 4db37a67cf03ce3197fe13e2bd02cc9fc7541a769ae084dba8505fd283be750b | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-threading-apartment | 0.2.4 | fdb9b6a696e839e0e12116c652859606b20c0832960f290291cb116937bfb65b | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| guide/winui2-to-winui3-windowing | 0.2.4 | f6aa138ce2ec9b9b68bacbc03964d7a7f6bcb8c370736806141626cd447340d8 | available; actual grounding is recorded per model invocation; resolved rules-store skill |
| prompt-template/WinUI.Migrate.Platform.Reasoning | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | a98e20d2cf67466488203a5b257fdbcc | configured; WinUI.Migrate.Platform.Reasoning.PromptBuilder |
| model-transport/WinUI.Migrate.Platform.Reasoning | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | a98e20d2cf67466488203a5b257fdbcc | configured; WinUI.Migrate.Platform.Reasoning.CopilotTransport |
| model-transport/copilot.exe | 1.0.97 | 682eb8de6a433ad5a1f5b291183c90e4b05239d58f5f0345acc89279da4f0735 | configured; C:\Users\raghavmadan\AppData\Local\Microsoft\WinGet\Links\copilot.exe |
| model/provider default | not reported |  | configured alias, not an observed provider revision; effort=medium; help-only invocation preflight (30 seconds, 64 KiB per pipe, up to 10 seconds for cleanup); transport configuration |
| tool/AddUsingStatement | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.AddUsingStatementHandler |
| tool/ReplaceNamespace | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.ReplaceNamespaceHandler |
| tool/QualifyMovedName | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.QualifyMovedNameHandler |
| tool/MigrateXamlMaterial | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.MigrateXamlMaterialHandler |
| tool/RepairUsingPlacement | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.RepairUsingPlacementHandler |
| tool/RemoveLifetimeManagerInstrumentation | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.RemoveLifetimeManagerInstrumentationHandler |
| tool/MigrateUwpLifecycle | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.MigrateUwpLifecycleHandler |
| tool/MigrateDesktopLifecycle | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.MigrateDesktopLifecycleHandler |
| tool/MigrateWinUiTestHost | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.MigrateWinUiTestHostHandler |
| tool/ApplyPackageConfiguration | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.ApplyPackageConfigurationHandler |
| tool/MigrateSingleWindowApis | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.MigrateSingleWindowApisHandler |
| tool/ApplyWindowOwnershipRecipe | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.ApplyWindowOwnershipRecipeHandler |
| tool/RemoveUnsupportedXamlAttribute | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.RemoveUnsupportedXamlAttributeHandler |
| tool/UpdatePackageReference | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.UpdatePackageReferenceHandler |
| tool/UpdateProjectProperty | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.UpdateProjectPropertyHandler |
| tool/ReplaceInvocationArgument | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.ReplaceInvocationArgumentHandler |
| tool/ReplaceInvocationName | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.ReplaceInvocationNameHandler |
| tool/CopyReadonlyRefArgument | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.CopyReadonlyRefArgumentHandler |
| tool/RepairDataTransferManagerInteropActivation | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.RepairDataTransferManagerInteropActivationHandler |
| tool/RepairWinAppDriverLifecycle | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.RepairWinAppDriverLifecycleHandler |
| tool/RepairPackageActivationEntryPoint | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.RepairPackageActivationEntryPointHandler |
| tool/RetargetProject | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | bea9eb9be91a49f3811e00cceac91dc2 | configured; WinUI.Migrate.Platform.Execution.Handlers.RetargetProjectHandler |
| tool/RestoreProject | 0.2.4+dcfee2991ff82f9360fbb542552350c8e1fc2bdf | fdb0eec8ceb04eb88d85536027b8b742 | configured; WinUI.Migrate.Platform.Build.RestoreProjectHandler |
| package-source-configuration/nuget.config | reviewed-content-v1 | 8ae8d19e861e4e2ab78ea9ea61cecbc420ba90278c5c602b87d0313348cde6c0 | configured; C:\Users\raghavmadan\.copilot\session-state\52f15054-86e8-4212-b97b-e50be2b17a1f\files\calculator-review\proposed-nuget.config |
| repair-proposer-profile/winui-skill-repair-v1 | 2 | cadd1a15afe9665e3797d9ed5551a7b768a1be59798d0f6ee6f2af9aac931a17 | validated Copilot CLI 1.0.84-8; reviewed read-only proposer protocol, tools, and limits |

## Acceptance criteria and fixed checklist
Policy: `required-evidence-v2`; original required count: 123; previous approved required count: 123.
| Check | Target / evaluator | Required / applicable | Result | Reason / evidence |
| --- | --- | --- | --- | --- |
| ea0b2abcb05a5588 | CalcManager\CalcManager.vcxproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 4090f6e321fd4dab | CalcManager\CalcManager.vcxproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| a503260d6393a514 | CalcManager\CalcManager.vcxproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| f9b5396aebfa3f1d | CalcManager\CalcManager.vcxproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 15f8b41eaa3f03c3 | CalcManager\CalcManager.vcxproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 18c74e45f3737d12 | CalcManager\CalcManager.vcxproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 00df4bed28af2dbd | CalcManager\CalcManager.vcxproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| e8c213638fa37073 | CalcManager\CalcManager.vcxproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 97e71deecc7b87b4 | CalcManager\CalcManager.vcxproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| fdbd56d0b36d206e | CalcManager\CalcManager.vcxproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| aaca4c4fee05a5ec | CalcManager\CalcManager.vcxproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| 88d22bd683487312 | CalcManager\CalcManager.vcxproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 43edc4e5cfedff32 | CalcManager\CalcManager.vcxproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 9e886dcb82e748f0 | CalcManager.Interop\CalcManager.Interop.vcxproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 623951647ab9797b | CalcManager.Interop\CalcManager.Interop.vcxproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| b9e1d0601c5f3584 | CalcManager.Interop\CalcManager.Interop.vcxproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 439924855aacf9aa | CalcManager.Interop\CalcManager.Interop.vcxproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 830f58ca0df3c6e8 | CalcManager.Interop\CalcManager.Interop.vcxproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| de1e083b82f003c0 | CalcManager.Interop\CalcManager.Interop.vcxproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 6445402960d7b9f9 | CalcManager.Interop\CalcManager.Interop.vcxproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| e5ceaa3a0ac377f8 | CalcManager.Interop\CalcManager.Interop.vcxproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 4efb156d2123505c | CalcManager.Interop\CalcManager.Interop.vcxproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| d45b0e162b19e0e6 | CalcManager.Interop\CalcManager.Interop.vcxproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| 03d4dac4c5fa99c8 | CalcManager.Interop\CalcManager.Interop.vcxproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| 02e7817e2cec47e9 | CalcManager.Interop\CalcManager.Interop.vcxproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 2facabe1450b3c6e | CalcManager.Interop\CalcManager.Interop.vcxproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| d1b864a8746015c1 | TraceLogging.Managed\TraceLogging.Managed.csproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 5db3189a58182099 | TraceLogging.Managed\TraceLogging.Managed.csproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 0346baf46a96e630 | TraceLogging.Managed\TraceLogging.Managed.csproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 1bb4ad13fbfb80e0 | TraceLogging.Managed\TraceLogging.Managed.csproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 56c1e7b4f2fda486 | TraceLogging.Managed\TraceLogging.Managed.csproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 7fe9ffd0c8ec2467 | TraceLogging.Managed\TraceLogging.Managed.csproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 6ed9a11f89e5455c | TraceLogging.Managed\TraceLogging.Managed.csproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 4655efa667032dd4 | TraceLogging.Managed\TraceLogging.Managed.csproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| b58b077b1638d4f8 | TraceLogging.Managed\TraceLogging.Managed.csproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 8275bc5f3823b0d8 | TraceLogging.Managed\TraceLogging.Managed.csproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| 8263f7d7d2f7e589 | TraceLogging.Managed\TraceLogging.Managed.csproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| 987eae4513fb9f8a | TraceLogging.Managed\TraceLogging.Managed.csproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 26c0a69ec5c3fc63 | TraceLogging.Managed\TraceLogging.Managed.csproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 5444b4cc865621a3 | Calculator.ViewModels\Calculator.ViewModels.csproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 2d02770c6afcc353 | Calculator.ViewModels\Calculator.ViewModels.csproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 7a5d2d5415a08323 | Calculator.ViewModels\Calculator.ViewModels.csproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 845d1695598f2cac | Calculator.ViewModels\Calculator.ViewModels.csproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 0d438c5bd1868290 | Calculator.ViewModels\Calculator.ViewModels.csproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 7ed27f8f8ea73376 | Calculator.ViewModels\Calculator.ViewModels.csproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| d10a91879edd087b | Calculator.ViewModels\Calculator.ViewModels.csproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 2d2689a322c7e19e | Calculator.ViewModels\Calculator.ViewModels.csproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 19b878c24259941f | Calculator.ViewModels\Calculator.ViewModels.csproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| b1ae40c12305b10c | Calculator.ViewModels\Calculator.ViewModels.csproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| d5fd467f5a50a35a | Calculator.ViewModels\Calculator.ViewModels.csproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| 545f03b948a7dd84 | Calculator.ViewModels\Calculator.ViewModels.csproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| ab7ab6a2263e8671 | Calculator.ViewModels\Calculator.ViewModels.csproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 0c3ee63d3728df10 | Calculator.Tests\Calculator.Tests.csproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 4aa0efa9ce5f185f | Calculator.Tests\Calculator.Tests.csproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| afbe73221e9712a4 | Calculator.Tests\Calculator.Tests.csproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 1cb4eab19f8e7ac5 | Calculator.Tests\Calculator.Tests.csproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 6f8deec927603eff | Calculator.Tests\Calculator.Tests.csproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 9b146816513cce63 | Calculator.Tests\Calculator.Tests.csproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 3f6615eaaae3b323 | Calculator.Tests\Calculator.Tests.csproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| e5ade81a833f76df | Calculator.Tests\Calculator.Tests.csproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| fa87e35b383db9d6 | Calculator.Tests\Calculator.Tests.csproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| c6c7eeab68e543ab | Calculator.Tests\Calculator.Tests.csproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| 0fa0c5d5cb290240 | Calculator.Tests\Calculator.Tests.csproj/test | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| cc21ed7cc3dd791e | Calculator.Tests\Calculator.Tests.csproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| de999bf911d1224d | Calculator.Tests\Calculator.Tests.csproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| ee64a7888c26ea2a | Calculator\Calculator.csproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| d30b2567f5abb05b | Calculator\Calculator.csproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 7969543de78c11e7 | Calculator\Calculator.csproj/launch | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 1a1fbe65b34e37d7 | Calculator\Calculator.csproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 3563335d279bee97 | Calculator\Calculator.csproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 066ede9a860c4804 | Calculator\Calculator.csproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 6c1c0e3b609c9075 | Calculator\Calculator.csproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| abd6044a64c3243a | Calculator\Calculator.csproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 7046a8df3fc6300a | Calculator\Calculator.csproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| a24559823ffcd7e2 | Calculator\Calculator.csproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| e5bac354906d2957 | Calculator\Calculator.csproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| 6ba3c07cd2a832e6 | Calculator\Calculator.csproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 09612aa318484c7e | Calculator\Calculator.csproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| ebc9c57fec88bf7b | CalculatorUITestFramework\CalculatorUITestFramework.csproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| b65b202bf9e6563a | CalculatorUITestFramework\CalculatorUITestFramework.csproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 875e447df0b24bb6 | CalculatorUITestFramework\CalculatorUITestFramework.csproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 5b3e033bac4376b6 | CalculatorUITestFramework\CalculatorUITestFramework.csproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 7fbed0b232922fb8 | CalculatorUITestFramework\CalculatorUITestFramework.csproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 2bd3115816f6d6dc | CalculatorUITestFramework\CalculatorUITestFramework.csproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 0a85d8e44bf0263b | CalculatorUITestFramework\CalculatorUITestFramework.csproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| cf4876ba0957bfd5 | CalculatorUITestFramework\CalculatorUITestFramework.csproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| ae83eeafe8201f45 | CalculatorUITestFramework\CalculatorUITestFramework.csproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| a433b408c01358a6 | CalculatorUITestFramework\CalculatorUITestFramework.csproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| e71e27f71aeb9f4b | CalculatorUITestFramework\CalculatorUITestFramework.csproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| 488556e5709c56c1 | CalculatorUITestFramework\CalculatorUITestFramework.csproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 2a8096040cd22804 | CalculatorUITestFramework\CalculatorUITestFramework.csproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| ea3ceb6b2ca38548 | CalculatorUITests\CalculatorUITests.csproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 52f1dffdaf8a7109 | CalculatorUITests\CalculatorUITests.csproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 88da95815532ac0f | CalculatorUITests\CalculatorUITests.csproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| f16d63de8ef7889c | CalculatorUITests\CalculatorUITests.csproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 58a87350bd0072cd | CalculatorUITests\CalculatorUITests.csproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| a267fea12e49a017 | CalculatorUITests\CalculatorUITests.csproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| db427bcd364fbaf7 | CalculatorUITests\CalculatorUITests.csproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 70cb005ada20d1ad | CalculatorUITests\CalculatorUITests.csproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 4a683a2bc208f424 | CalculatorUITests\CalculatorUITests.csproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 8ed3b24bd6f999cd | CalculatorUITests\CalculatorUITests.csproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| 87582096903996eb | CalculatorUITests\CalculatorUITests.csproj/test | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| efe623b676f3a1d7 | CalculatorUITests\CalculatorUITests.csproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| c2806c1c39c26fde | CalculatorUITests\CalculatorUITests.csproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 177b78aee529736f | CalculatorUnitTests\CalculatorUnitTests.vcxproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| ccf0fd8b99255371 | CalculatorUnitTests\CalculatorUnitTests.vcxproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 68eab0cf60f0764b | CalculatorUnitTests\CalculatorUnitTests.vcxproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 58eae44467107c8a | CalculatorUnitTests\CalculatorUnitTests.vcxproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| af52bcb9955678f9 | CalculatorUnitTests\CalculatorUnitTests.vcxproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 4ddef734f10c7968 | CalculatorUnitTests\CalculatorUnitTests.vcxproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| ee8e81dc27856a8b | CalculatorUnitTests\CalculatorUnitTests.vcxproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 81ac4a8d7fc2dc0e | CalculatorUnitTests\CalculatorUnitTests.vcxproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| cb69571e614de222 | CalculatorUnitTests\CalculatorUnitTests.vcxproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| c68e07c1c235acb2 | CalculatorUnitTests\CalculatorUnitTests.vcxproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| 1788c5a47b15df95 | CalculatorUnitTests\CalculatorUnitTests.vcxproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| e88f9cdeab0c5905 | CalculatorUnitTests\CalculatorUnitTests.vcxproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| fd2ca705d3101a96 | CalculatorUnitTests\CalculatorUnitTests.vcxproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 95cfa64f3f6a8b70 | TraceLogging\TraceLogging.vcxproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 37f01ad15e4c2f15 | TraceLogging\TraceLogging.vcxproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 6550ea1e768d7ad6 | TraceLogging\TraceLogging.vcxproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 93640cd352a2308d | TraceLogging\TraceLogging.vcxproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| b3284b4a11c8aabe | TraceLogging\TraceLogging.vcxproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 592b20debdf92aff | TraceLogging\TraceLogging.vcxproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| edd95a119232c4a0 | TraceLogging\TraceLogging.vcxproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 577e606d117b6cec | TraceLogging\TraceLogging.vcxproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| cdb296ad8a743116 | TraceLogging\TraceLogging.vcxproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 072ab0dc0f42880a | TraceLogging\TraceLogging.vcxproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| 0575fb21bcb600e1 | TraceLogging\TraceLogging.vcxproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| 9b6b0c7f8e7b39ae | TraceLogging\TraceLogging.vcxproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 2f93f9e088525c10 | TraceLogging\TraceLogging.vcxproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| c1ce18af99f6b38d | GraphControl\GraphControl.vcxproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 05d805719bd1e94f | GraphControl\GraphControl.vcxproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| af519e343a79d1a0 | GraphControl\GraphControl.vcxproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 5972ae0f1ef1292a | GraphControl\GraphControl.vcxproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 8e412ba22783ab5c | GraphControl\GraphControl.vcxproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 4dd61e79bb453e8d | GraphControl\GraphControl.vcxproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| cd4583b68bfaf5e5 | GraphControl\GraphControl.vcxproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 644ff2cb23bcdbc7 | GraphControl\GraphControl.vcxproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 0768c5feea498874 | GraphControl\GraphControl.vcxproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| c081914e89cb8b30 | GraphControl\GraphControl.vcxproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| 3c4ddd20d20b5751 | GraphControl\GraphControl.vcxproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| cb51831cd3b5d7e8 | GraphControl\GraphControl.vcxproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 03b161578fadadf5 | GraphControl\GraphControl.vcxproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| aa2041fb2a54f6c4 | GraphingImpl\GraphingImpl.vcxproj/build | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| e66e7741d89c858d | GraphingImpl\GraphingImpl.vcxproj/install-signed-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 8c721f7f2adc5ea9 | GraphingImpl\GraphingImpl.vcxproj/launch | True / False | NotRun | Not applicable under the reviewed 'app' scope.; evaluation `none` |
| 78c3f2c78ee4036d | GraphingImpl\GraphingImpl.vcxproj/package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 175333449f8c1320 | GraphingImpl\GraphingImpl.vcxproj/package-configuration | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 9e5220dcaa3b02c3 | GraphingImpl\GraphingImpl.vcxproj/prepare-environment | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 5fa8c3cdf13e3cec | GraphingImpl\GraphingImpl.vcxproj/retarget | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| d26ad17c45474533 | GraphingImpl\GraphingImpl.vcxproj/runtime-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| 087ebc427703a03d | GraphingImpl\GraphingImpl.vcxproj/sign-package | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| f977b55998eae5ca | GraphingImpl\GraphingImpl.vcxproj/smoke-test | True / False | NotRun | Not applicable under the reviewed 'script' scope.; evaluation `none` |
| d598b55a690e2526 | GraphingImpl\GraphingImpl.vcxproj/test | True / False | NotRun | Not applicable under the reviewed 'tests' scope.; evaluation `none` |
| 1a5f8a72adfbbf58 | GraphingImpl\GraphingImpl.vcxproj/test-host-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| cb4829db7b9c2afd | GraphingImpl\GraphingImpl.vcxproj/windowing-compatibility | True / True | NotRun | Not attempted: BaselineBroken; evaluation `none` |
| b8cd9c7a088f8edc | */$criterion | True / True | NotRun | Independent outcome evidence is required. Supply a checked workflow named 'decision:Suspending:desktop-lifecycle=window-close' or approve a criterion revision. Verify with build, launch, smoke. The work runs when the window closes, not when Windows suspends the app; ending the process abruptly does not run it.; evaluation `none` |
- decision:Suspending:desktop-lifecycle=window-close: Requirement; Suspending was answered (a): Keep the suspension work and run it on the primary window's first close request: cancel that close, await the work, then close the window once (winui2-to-winui3-lifecycle).. Validate: Verify with build, launch, smoke. The work runs when the window closes, not when Windows suspends the app; ending the process abruptly does not run it.
- decision:Suspending:desktop-lifecycle=window-close: Suspending was answered (a): Keep the suspension work and run it on the primary window's first close request: cancel that close, await the work, then close the window once (winui2-to-winui3-lifecycle).; Implementation/semantic adherence not automatically established.; Manual verification required: Verify with build, launch, smoke. The work runs when the window closes, not when Windows suspends the app; ending the process abruptly does not run it.

## Budgets and usage
Execution allowances are per target/evaluator. Aggregate executions are not compared with a single allowance.
| Budget / scope | Limit | Consumed | Remaining | Unit | Enforcement / source |
| --- | --- | --- | --- | --- | --- |
| attempts:ea0b2abcb05a5588 / CalcManager\CalcManager.vcxproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:4090f6e321fd4dab / CalcManager\CalcManager.vcxproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:a503260d6393a514 / CalcManager\CalcManager.vcxproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:f9b5396aebfa3f1d / CalcManager\CalcManager.vcxproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:15f8b41eaa3f03c3 / CalcManager\CalcManager.vcxproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:18c74e45f3737d12 / CalcManager\CalcManager.vcxproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:00df4bed28af2dbd / CalcManager\CalcManager.vcxproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:e8c213638fa37073 / CalcManager\CalcManager.vcxproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:97e71deecc7b87b4 / CalcManager\CalcManager.vcxproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:fdbd56d0b36d206e / CalcManager\CalcManager.vcxproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:aaca4c4fee05a5ec / CalcManager\CalcManager.vcxproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:88d22bd683487312 / CalcManager\CalcManager.vcxproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:43edc4e5cfedff32 / CalcManager\CalcManager.vcxproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:9e886dcb82e748f0 / CalcManager.Interop\CalcManager.Interop.vcxproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:623951647ab9797b / CalcManager.Interop\CalcManager.Interop.vcxproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:b9e1d0601c5f3584 / CalcManager.Interop\CalcManager.Interop.vcxproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:439924855aacf9aa / CalcManager.Interop\CalcManager.Interop.vcxproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:830f58ca0df3c6e8 / CalcManager.Interop\CalcManager.Interop.vcxproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:de1e083b82f003c0 / CalcManager.Interop\CalcManager.Interop.vcxproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:6445402960d7b9f9 / CalcManager.Interop\CalcManager.Interop.vcxproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:e5ceaa3a0ac377f8 / CalcManager.Interop\CalcManager.Interop.vcxproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:4efb156d2123505c / CalcManager.Interop\CalcManager.Interop.vcxproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:d45b0e162b19e0e6 / CalcManager.Interop\CalcManager.Interop.vcxproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:03d4dac4c5fa99c8 / CalcManager.Interop\CalcManager.Interop.vcxproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:02e7817e2cec47e9 / CalcManager.Interop\CalcManager.Interop.vcxproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:2facabe1450b3c6e / CalcManager.Interop\CalcManager.Interop.vcxproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:d1b864a8746015c1 / TraceLogging.Managed\TraceLogging.Managed.csproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:5db3189a58182099 / TraceLogging.Managed\TraceLogging.Managed.csproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:0346baf46a96e630 / TraceLogging.Managed\TraceLogging.Managed.csproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:1bb4ad13fbfb80e0 / TraceLogging.Managed\TraceLogging.Managed.csproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:56c1e7b4f2fda486 / TraceLogging.Managed\TraceLogging.Managed.csproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:7fe9ffd0c8ec2467 / TraceLogging.Managed\TraceLogging.Managed.csproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:6ed9a11f89e5455c / TraceLogging.Managed\TraceLogging.Managed.csproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:4655efa667032dd4 / TraceLogging.Managed\TraceLogging.Managed.csproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:b58b077b1638d4f8 / TraceLogging.Managed\TraceLogging.Managed.csproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:8275bc5f3823b0d8 / TraceLogging.Managed\TraceLogging.Managed.csproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:8263f7d7d2f7e589 / TraceLogging.Managed\TraceLogging.Managed.csproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:987eae4513fb9f8a / TraceLogging.Managed\TraceLogging.Managed.csproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:26c0a69ec5c3fc63 / TraceLogging.Managed\TraceLogging.Managed.csproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:5444b4cc865621a3 / Calculator.ViewModels\Calculator.ViewModels.csproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:2d02770c6afcc353 / Calculator.ViewModels\Calculator.ViewModels.csproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:7a5d2d5415a08323 / Calculator.ViewModels\Calculator.ViewModels.csproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:845d1695598f2cac / Calculator.ViewModels\Calculator.ViewModels.csproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:0d438c5bd1868290 / Calculator.ViewModels\Calculator.ViewModels.csproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:7ed27f8f8ea73376 / Calculator.ViewModels\Calculator.ViewModels.csproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:d10a91879edd087b / Calculator.ViewModels\Calculator.ViewModels.csproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:2d2689a322c7e19e / Calculator.ViewModels\Calculator.ViewModels.csproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:19b878c24259941f / Calculator.ViewModels\Calculator.ViewModels.csproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:b1ae40c12305b10c / Calculator.ViewModels\Calculator.ViewModels.csproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:d5fd467f5a50a35a / Calculator.ViewModels\Calculator.ViewModels.csproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:545f03b948a7dd84 / Calculator.ViewModels\Calculator.ViewModels.csproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:ab7ab6a2263e8671 / Calculator.ViewModels\Calculator.ViewModels.csproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:0c3ee63d3728df10 / Calculator.Tests\Calculator.Tests.csproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:4aa0efa9ce5f185f / Calculator.Tests\Calculator.Tests.csproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:afbe73221e9712a4 / Calculator.Tests\Calculator.Tests.csproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:1cb4eab19f8e7ac5 / Calculator.Tests\Calculator.Tests.csproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:6f8deec927603eff / Calculator.Tests\Calculator.Tests.csproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:9b146816513cce63 / Calculator.Tests\Calculator.Tests.csproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:3f6615eaaae3b323 / Calculator.Tests\Calculator.Tests.csproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:e5ade81a833f76df / Calculator.Tests\Calculator.Tests.csproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:fa87e35b383db9d6 / Calculator.Tests\Calculator.Tests.csproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:c6c7eeab68e543ab / Calculator.Tests\Calculator.Tests.csproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:0fa0c5d5cb290240 / Calculator.Tests\Calculator.Tests.csproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:cc21ed7cc3dd791e / Calculator.Tests\Calculator.Tests.csproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:de999bf911d1224d / Calculator.Tests\Calculator.Tests.csproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:ee64a7888c26ea2a / Calculator\Calculator.csproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:d30b2567f5abb05b / Calculator\Calculator.csproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:7969543de78c11e7 / Calculator\Calculator.csproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:1a1fbe65b34e37d7 / Calculator\Calculator.csproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:3563335d279bee97 / Calculator\Calculator.csproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:066ede9a860c4804 / Calculator\Calculator.csproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:6c1c0e3b609c9075 / Calculator\Calculator.csproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:abd6044a64c3243a / Calculator\Calculator.csproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:7046a8df3fc6300a / Calculator\Calculator.csproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:a24559823ffcd7e2 / Calculator\Calculator.csproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:e5bac354906d2957 / Calculator\Calculator.csproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:6ba3c07cd2a832e6 / Calculator\Calculator.csproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:09612aa318484c7e / Calculator\Calculator.csproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:ebc9c57fec88bf7b / CalculatorUITestFramework\CalculatorUITestFramework.csproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:b65b202bf9e6563a / CalculatorUITestFramework\CalculatorUITestFramework.csproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:875e447df0b24bb6 / CalculatorUITestFramework\CalculatorUITestFramework.csproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:5b3e033bac4376b6 / CalculatorUITestFramework\CalculatorUITestFramework.csproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:7fbed0b232922fb8 / CalculatorUITestFramework\CalculatorUITestFramework.csproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:2bd3115816f6d6dc / CalculatorUITestFramework\CalculatorUITestFramework.csproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:0a85d8e44bf0263b / CalculatorUITestFramework\CalculatorUITestFramework.csproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:cf4876ba0957bfd5 / CalculatorUITestFramework\CalculatorUITestFramework.csproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:ae83eeafe8201f45 / CalculatorUITestFramework\CalculatorUITestFramework.csproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:a433b408c01358a6 / CalculatorUITestFramework\CalculatorUITestFramework.csproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:e71e27f71aeb9f4b / CalculatorUITestFramework\CalculatorUITestFramework.csproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:488556e5709c56c1 / CalculatorUITestFramework\CalculatorUITestFramework.csproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:2a8096040cd22804 / CalculatorUITestFramework\CalculatorUITestFramework.csproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:ea3ceb6b2ca38548 / CalculatorUITests\CalculatorUITests.csproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:52f1dffdaf8a7109 / CalculatorUITests\CalculatorUITests.csproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:88da95815532ac0f / CalculatorUITests\CalculatorUITests.csproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:f16d63de8ef7889c / CalculatorUITests\CalculatorUITests.csproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:58a87350bd0072cd / CalculatorUITests\CalculatorUITests.csproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:a267fea12e49a017 / CalculatorUITests\CalculatorUITests.csproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:db427bcd364fbaf7 / CalculatorUITests\CalculatorUITests.csproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:70cb005ada20d1ad / CalculatorUITests\CalculatorUITests.csproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:4a683a2bc208f424 / CalculatorUITests\CalculatorUITests.csproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:8ed3b24bd6f999cd / CalculatorUITests\CalculatorUITests.csproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:87582096903996eb / CalculatorUITests\CalculatorUITests.csproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:efe623b676f3a1d7 / CalculatorUITests\CalculatorUITests.csproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:c2806c1c39c26fde / CalculatorUITests\CalculatorUITests.csproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:177b78aee529736f / CalculatorUnitTests\CalculatorUnitTests.vcxproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:ccf0fd8b99255371 / CalculatorUnitTests\CalculatorUnitTests.vcxproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:68eab0cf60f0764b / CalculatorUnitTests\CalculatorUnitTests.vcxproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:58eae44467107c8a / CalculatorUnitTests\CalculatorUnitTests.vcxproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:af52bcb9955678f9 / CalculatorUnitTests\CalculatorUnitTests.vcxproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:4ddef734f10c7968 / CalculatorUnitTests\CalculatorUnitTests.vcxproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:ee8e81dc27856a8b / CalculatorUnitTests\CalculatorUnitTests.vcxproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:81ac4a8d7fc2dc0e / CalculatorUnitTests\CalculatorUnitTests.vcxproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:cb69571e614de222 / CalculatorUnitTests\CalculatorUnitTests.vcxproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:c68e07c1c235acb2 / CalculatorUnitTests\CalculatorUnitTests.vcxproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:1788c5a47b15df95 / CalculatorUnitTests\CalculatorUnitTests.vcxproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:e88f9cdeab0c5905 / CalculatorUnitTests\CalculatorUnitTests.vcxproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:fd2ca705d3101a96 / CalculatorUnitTests\CalculatorUnitTests.vcxproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:95cfa64f3f6a8b70 / TraceLogging\TraceLogging.vcxproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:37f01ad15e4c2f15 / TraceLogging\TraceLogging.vcxproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:6550ea1e768d7ad6 / TraceLogging\TraceLogging.vcxproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:93640cd352a2308d / TraceLogging\TraceLogging.vcxproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:b3284b4a11c8aabe / TraceLogging\TraceLogging.vcxproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:592b20debdf92aff / TraceLogging\TraceLogging.vcxproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:edd95a119232c4a0 / TraceLogging\TraceLogging.vcxproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:577e606d117b6cec / TraceLogging\TraceLogging.vcxproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:cdb296ad8a743116 / TraceLogging\TraceLogging.vcxproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:072ab0dc0f42880a / TraceLogging\TraceLogging.vcxproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:0575fb21bcb600e1 / TraceLogging\TraceLogging.vcxproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:9b6b0c7f8e7b39ae / TraceLogging\TraceLogging.vcxproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:2f93f9e088525c10 / TraceLogging\TraceLogging.vcxproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:c1ce18af99f6b38d / GraphControl\GraphControl.vcxproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:05d805719bd1e94f / GraphControl\GraphControl.vcxproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:af519e343a79d1a0 / GraphControl\GraphControl.vcxproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:5972ae0f1ef1292a / GraphControl\GraphControl.vcxproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:8e412ba22783ab5c / GraphControl\GraphControl.vcxproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:4dd61e79bb453e8d / GraphControl\GraphControl.vcxproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:cd4583b68bfaf5e5 / GraphControl\GraphControl.vcxproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:644ff2cb23bcdbc7 / GraphControl\GraphControl.vcxproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:0768c5feea498874 / GraphControl\GraphControl.vcxproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:c081914e89cb8b30 / GraphControl\GraphControl.vcxproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:3c4ddd20d20b5751 / GraphControl\GraphControl.vcxproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:cb51831cd3b5d7e8 / GraphControl\GraphControl.vcxproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:03b161578fadadf5 / GraphControl\GraphControl.vcxproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:aa2041fb2a54f6c4 / GraphingImpl\GraphingImpl.vcxproj/build | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:e66e7741d89c858d / GraphingImpl\GraphingImpl.vcxproj/install-signed-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:8c721f7f2adc5ea9 / GraphingImpl\GraphingImpl.vcxproj/launch | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:78c3f2c78ee4036d / GraphingImpl\GraphingImpl.vcxproj/package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:175333449f8c1320 / GraphingImpl\GraphingImpl.vcxproj/package-configuration | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:9e5220dcaa3b02c3 / GraphingImpl\GraphingImpl.vcxproj/prepare-environment | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:5fa8c3cdf13e3cec / GraphingImpl\GraphingImpl.vcxproj/retarget | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:d26ad17c45474533 / GraphingImpl\GraphingImpl.vcxproj/runtime-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:087ebc427703a03d / GraphingImpl\GraphingImpl.vcxproj/sign-package | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:f977b55998eae5ca / GraphingImpl\GraphingImpl.vcxproj/smoke-test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:d598b55a690e2526 / GraphingImpl\GraphingImpl.vcxproj/test | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:1a5f8a72adfbbf58 / GraphingImpl\GraphingImpl.vcxproj/test-host-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| attempts:cb4829db7b9c2afd / GraphingImpl\GraphingImpl.vcxproj/windowing-compatibility | 10 | 0 | 10 | executions | hard; reviewed request MaxRounds; per target/evaluator; Started executions, including interrupted attempts; invalidation does not reset usage. |
| rechecks:6fbc79053be9d04d / CalcManager\CalcManager.vcxproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:ea8998817f55ed7b / CalcManager.Interop\CalcManager.Interop.vcxproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:09326aefe5f22329 / TraceLogging.Managed\TraceLogging.Managed.csproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:2657cd50b345c065 / Calculator.ViewModels\Calculator.ViewModels.csproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:bce60b3bdd17e42a / Calculator.Tests\Calculator.Tests.csproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:a6f9627cd852f95d / Calculator\Calculator.csproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:3b0223bcbdaeff37 / CalculatorUITestFramework\CalculatorUITestFramework.csproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:38a903f41c6d9097 / CalculatorUITests\CalculatorUITests.csproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:762896f03704af1c / CalculatorUnitTests\CalculatorUnitTests.vcxproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:f11280c6c3832e87 / TraceLogging\TraceLogging.vcxproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:9611a4c8d4eb5f80 / GraphControl\GraphControl.vcxproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| rechecks:a1dbaffef118374d / GraphingImpl\GraphingImpl.vcxproj | 10 | 0 | 10 | rechecks | hard; reviewed MaxRounds; input-revalidation restarts per target, separate from repair attempts; Input-revalidation restarts per target; separate from, and never resetting, repair attempts. |
| prepare-environment:timeout / prepare-environment invocation | 600 | unknown | unknown | seconds | hard; resolved environment preparation definition; Not reported; remaining allowance is unknown. |
| prepare-environment:output / prepare-environment invocation | 1048576 | unknown | unknown | UTF-8 bytes | capture limit; resolved environment preparation definition; Not reported; remaining allowance is unknown. |
| build:timeout / build invocation | 1800 | unknown | unknown | seconds | hard; resolved build definition; Not reported; remaining allowance is unknown. |
| build:output / build invocation | 10485760 | unknown | unknown | UTF-8 bytes | capture limit; resolved build definition; Not reported; remaining allowance is unknown. |
| launch:timeout / launch invocation | 120 | unknown | unknown | seconds | hard; resolved launch definition; Not reported; remaining allowance is unknown. |
| launch:output / launch invocation | 10485760 | unknown | unknown | UTF-8 bytes | capture limit; resolved launch definition; Not reported; remaining allowance is unknown. |
| winapp-debug:timeout / winapp-debug invocation | 300 | unknown | unknown | seconds | hard; native-build-winapp-debug-20s-v1; Not reported; remaining allowance is unknown. |
| winapp-debug:output / winapp-debug invocation | 10485760 | unknown | unknown | UTF-8 bytes | capture limit; native-build-winapp-debug-20s-v1; Not reported; remaining allowance is unknown. |
| package:timeout / package invocation | 600 | unknown | unknown | seconds | hard; confirmed-launch-verified-native-output-winapp-unsigned-msix-v3; Not reported; remaining allowance is unknown. |
| package:output / package invocation | 16777216 | unknown | unknown | UTF-8 bytes | capture limit; confirmed-launch-verified-native-output-winapp-unsigned-msix-v3; Not reported; remaining allowance is unknown. |
| sign-package:timeout / sign-package invocation | 300 | unknown | unknown | seconds | hard; winapp-dev-certificate-sign-uac-trust-install-v2; Not reported; remaining allowance is unknown. |
| sign-package:output / sign-package invocation | 4194304 | unknown | unknown | UTF-8 bytes | capture limit; winapp-dev-certificate-sign-uac-trust-install-v2; Not reported; remaining allowance is unknown. |
| install-signed-package:timeout / install-signed-package invocation | 600 | unknown | unknown | seconds | hard; winapp-dev-certificate-sign-uac-trust-install-v2; Not reported; remaining allowance is unknown. |
| install-signed-package:output / install-signed-package invocation | 4194304 | unknown | unknown | UTF-8 bytes | capture limit; winapp-dev-certificate-sign-uac-trust-install-v2; Not reported; remaining allowance is unknown. |
| test:timeout / test invocation | 900 | unknown | unknown | seconds | hard; TestEvaluator; Not reported; remaining allowance is unknown. |
| test:output / test invocation | 20971520 | unknown | unknown | UTF-8 bytes | capture limit; TestEvaluator; Not reported; remaining allowance is unknown. |
| smoke-test:timeout / smoke-test invocation | 300 | unknown | unknown | seconds | hard; SmokeTestEvaluator; Not reported; remaining allowance is unknown. |
| smoke-test:output / smoke-test invocation | 10485760 | unknown | unknown | UTF-8 bytes | capture limit; SmokeTestEvaluator; Not reported; remaining allowance is unknown. |
| model:timeout / model invocation | 180 | unknown | unknown | seconds | hard; ReasoningService; Not reported; remaining allowance is unknown. |
| model:prompt / model invocation | 24000 | unknown | unknown | characters | advisory composition target; PromptBuilder; Not reported; remaining allowance is unknown. |
| model:command-prompt / model invocation | 30000 | unknown | unknown | characters | hard; CopilotTransport; Not reported; remaining allowance is unknown. |
| restore:timeout / restore invocation | 600 | unknown | unknown | seconds | hard; resolved restore definition; Not reported; remaining allowance is unknown. |
| restore:output / restore invocation | 10485760 | unknown | unknown | UTF-8 bytes | capture limit; resolved restore definition; Not reported; remaining allowance is unknown. |
| repair:generation / automatic MissingCapability proposal | 600 | unknown | unknown | seconds | hard cooperative deadline; reviewed one-command continuation policy; Not reported; remaining allowance is unknown. |
| repair:candidates / automatic MissingCapability proposal | 1 | unknown | unknown | calls | one preparation claim per sealed parent run; reviewed one-command continuation policy; Not reported; remaining allowance is unknown. |
| repair:files / automatic MissingCapability proposal | 16 | unknown | unknown | files | hard; ReviewedRepairService; Not reported; remaining allowance is unknown. |
| repair:source-bytes / automatic MissingCapability proposal | 131072 | unknown | unknown | UTF-8 bytes | hard; ReviewedRepairService; Not reported; remaining allowance is unknown. |
| repair:prompt-characters / automatic MissingCapability proposal | 30000 | unknown | unknown | characters | hard; ReviewedRepairService; Not reported; remaining allowance is unknown. |
| repair:context-files / read-only repair proposer context | 2000 | unknown | unknown | files | hard; no partial context; ReviewedRepairService; Not reported; remaining allowance is unknown. |
| repair:context-bytes / read-only repair proposer context | 33554432 | unknown | unknown | bytes | hard; no partial context; ReviewedRepairService; Not reported; remaining allowance is unknown. |
| repair:context-file-bytes / read-only repair proposer file | 524288 | unknown | unknown | bytes | hard; no truncation; ReviewedRepairService; Not reported; remaining allowance is unknown. |
| repair:agent-tool-calls / read-only repair proposer | 64 | unknown | unknown | calls | hard; ReviewedRepairService; Not reported; remaining allowance is unknown. |
| repair:agent-tool-results / read-only repair proposer | 8388608 | unknown | unknown | UTF-8 bytes | hard; no truncation; ReviewedRepairService; Not reported; remaining allowance is unknown. |
| run:wall-time / approved execution; finalization excluded | unknown | 55799 | unknown | milliseconds | not configured; reviewed MaxDurationSeconds; monotonic execution clock; Controller monotonic elapsed execution time, not summed stage durations. |
| run:model-tokens / run | unknown | 0 | unknown | tokens | not configured; provider-reported usage only; Observed input + output tokens; cache/replay excludes historical charges. Missing fields prevent a total. |
| run:cost / run | unknown | unknown | unknown | currency | not configured; no pricing assumptions; Not reported; remaining allowance is unknown. |

## Plan preview vs actual
Forecast vs actual: 0 of 11 forecast project actions ran (precision 0%); 0 of 0 applied project actions were forecast (coverage n/a). 46 forecast steps had no executor action to confirm them. The run stopped (BaselineBroken) before finishing, so precision is a lower bound.
Matched per project and executor action, not step by step. Loop support (a restore after a retarget) is shown but not counted.

| Project | Action | Outcome | Forecast steps | Attempted | Applied |
| --- | --- | --- | --- | --- | --- |
| (solution) | RemoveUnsupportedXamlAttribute | predicted-not-run | 1 | 0 | 0 |
| Calculator.Tests\Calculator.Tests.csproj | ReplaceNamespace | predicted-not-run | 2 | 0 | 0 |
| Calculator.ViewModels\Calculator.ViewModels.csproj | AddUsingStatement | predicted-not-run | 1 | 0 | 0 |
| Calculator.ViewModels\Calculator.ViewModels.csproj | MigrateSingleWindowApis | predicted-not-run | 1 | 0 | 0 |
| Calculator.ViewModels\Calculator.ViewModels.csproj | ReplaceNamespace | predicted-not-run | 4 | 0 | 0 |
| CalculatorUITestFramework\CalculatorUITestFramework.csproj | ReplaceNamespace | predicted-not-run | 1 | 0 | 0 |
| Calculator\Calculator.csproj | AddUsingStatement | predicted-not-run | 1 | 0 | 0 |
| Calculator\Calculator.csproj | MigrateSingleWindowApis | predicted-not-run | 3 | 0 | 0 |
| Calculator\Calculator.csproj | MigrateUwpLifecycle | predicted-not-run | 1 | 0 | 0 |
| Calculator\Calculator.csproj | MigrateXamlMaterial | predicted-not-run | 2 | 0 | 0 |
| Calculator\Calculator.csproj | ReplaceNamespace | predicted-not-run | 25 | 0 | 0 |

## Controller overhead
| Work | Calls | Duration ms | Files observed / hashed / reused | Bytes read |
| --- | --- | --- | --- | --- |
| Source fingerprint captures (2 full, 0 incremental, 0 fallback) | 2 | 1131 | 1452 / 1452 / 0 | 38167834 |
| Ledger refresh, including store access but excluding the source capture | 1 | 36 | not applicable | not applicable |
These counters cover instrumented controller boundaries, not assessment or finalization captures. Generator attribution is command/contract evidence, not independent file-I/O attestation.

## Change attribution
| Classification | Count | Basis |
| --- | --- | --- |
| Deterministic harness change | 0 | Checked action results |
| Model-proposed / human-approved / controller-applied | 0 | Exact proposal and reviewed-file events |
| Generated evaluator output | 0 | Evaluator output events |
| External or unattributed change | 0 | Final input delta without an owning event |

## Chronological actions, attempts and human interventions
| UTC | Kind / operation | State | Duration ms | Actor / authority / details |
| --- | --- | --- | --- | --- |
| 2026-11-12T11:43:30.2625013+00:00 | input-snapshot/run-20261112-114328-af03e6 | completed | 558 | controller; ; full capture: 726 hashed, 0 reused, 726 observed; 0 unreadable-input gaps. |
| 2026-11-12T11:43:28.0739906+00:00 | approval/run-20261112-114328-af03e6 | admitted | not reported | raghavmadan; host review callback; Approved assessment 806679bc0bf2ffc13dde5e04a74c306671ba07a240baa330f5f95c05b3bdccb5. |
| 2026-11-12T11:44:24.1134937+00:00 | baseline-gate/EVAL-11 | Fail | 34049 | controller; ; msbuild reported 24 errors with 28 warnings building Calculator.slnx. |
| 2026-11-12T11:44:24.1189179+00:00 | baseline-gate/EVAL-12 | NotRun | 0 | controller; ; Not launched: the baseline build was Fail. |
| 2026-11-12T11:44:24.7338356+00:00 | input-snapshot/ledger-f54e323b966143c6b72dfa9f25507908 | completed | 573 | controller; ; full capture: 726 hashed, 0 reused, 726 observed; 0 unreadable-input gaps. |
| 2026-11-12T11:44:24.7698431+00:00 | ledger-refresh/ledger-f54e323b966143c6b72dfa9f25507908 | completed | 36 | controller; ; 157 checks; 13 distinct input scopes. Duration excludes the separately recorded source capture. |

## Resource usage (unknown is not zero)
| Operation | Input / output / cache-read tokens | CPU ms / peak bytes / output bytes | Measurement |
| --- | --- | --- | --- |
| run-20261112-114328-af03e6 | unknown / unknown / unknown | unknown / unknown / unknown | full content-hash capture; bytes actually read, including inherited configuration. |
| ledger-f54e323b966143c6b72dfa9f25507908 | unknown / unknown / unknown | unknown / unknown / unknown | full content-hash capture; bytes actually read, including inherited configuration. |

## Artifacts, remaining work and limitations
Working database: `C:\phase2\calculator-winui3\.winui-migrate\working\migration.db`.
Archive commit marker: `C:\phase2\calculator-winui3\.winui-migrate\runs\run-20261112-114328-af03e6\manifest.json`.
| Relative artifact | SHA-256 | State |
| --- | --- | --- |
| ..\assessment\approval.json | b6bf4bf5ca5d2674e6dfa7a5cf1517926ca7377dce02297faa7398b5d3f2242e | present |
| ..\assessment\approval-evidence.json | 43f31f5ed35cd5f78ad4aa3bf4674a2d2f1ab7d3d047ba7b1918dc1015ed6cf4 | present |
| ..\artifacts\baseline\build-round-0-cc07733d.log | 871068e0fd303490331ef58b4285b023f51fe509f21d0b26c504994320508c15 | present |
- Remaining ea0b2abcb05a5588: NotRun. Not attempted: BaselineBroken
- Remaining 4090f6e321fd4dab: NotRun. Not attempted: BaselineBroken
- Remaining f9b5396aebfa3f1d: NotRun. Not attempted: BaselineBroken
- Remaining 15f8b41eaa3f03c3: NotRun. Not attempted: BaselineBroken
- Remaining 18c74e45f3737d12: NotRun. Not attempted: BaselineBroken
- Remaining 00df4bed28af2dbd: NotRun. Not attempted: BaselineBroken
- Remaining e8c213638fa37073: NotRun. Not attempted: BaselineBroken
- Remaining 97e71deecc7b87b4: NotRun. Not attempted: BaselineBroken
- Remaining 88d22bd683487312: NotRun. Not attempted: BaselineBroken
- Remaining 43edc4e5cfedff32: NotRun. Not attempted: BaselineBroken
- Remaining 9e886dcb82e748f0: NotRun. Not attempted: BaselineBroken
- Remaining 623951647ab9797b: NotRun. Not attempted: BaselineBroken
- Remaining 439924855aacf9aa: NotRun. Not attempted: BaselineBroken
- Remaining 830f58ca0df3c6e8: NotRun. Not attempted: BaselineBroken
- Remaining de1e083b82f003c0: NotRun. Not attempted: BaselineBroken
- Remaining 6445402960d7b9f9: NotRun. Not attempted: BaselineBroken
- Remaining e5ceaa3a0ac377f8: NotRun. Not attempted: BaselineBroken
- Remaining 4efb156d2123505c: NotRun. Not attempted: BaselineBroken
- Remaining 02e7817e2cec47e9: NotRun. Not attempted: BaselineBroken
- Remaining 2facabe1450b3c6e: NotRun. Not attempted: BaselineBroken
- Remaining d1b864a8746015c1: NotRun. Not attempted: BaselineBroken
- Remaining 5db3189a58182099: NotRun. Not attempted: BaselineBroken
- Remaining 1bb4ad13fbfb80e0: NotRun. Not attempted: BaselineBroken
- Remaining 56c1e7b4f2fda486: NotRun. Not attempted: BaselineBroken
- Remaining 7fe9ffd0c8ec2467: NotRun. Not attempted: BaselineBroken
- Remaining 6ed9a11f89e5455c: NotRun. Not attempted: BaselineBroken
- Remaining 4655efa667032dd4: NotRun. Not attempted: BaselineBroken
- Remaining b58b077b1638d4f8: NotRun. Not attempted: BaselineBroken
- Remaining 987eae4513fb9f8a: NotRun. Not attempted: BaselineBroken
- Remaining 26c0a69ec5c3fc63: NotRun. Not attempted: BaselineBroken
- Remaining 5444b4cc865621a3: NotRun. Not attempted: BaselineBroken
- Remaining 2d02770c6afcc353: NotRun. Not attempted: BaselineBroken
- Remaining 845d1695598f2cac: NotRun. Not attempted: BaselineBroken
- Remaining 0d438c5bd1868290: NotRun. Not attempted: BaselineBroken
- Remaining 7ed27f8f8ea73376: NotRun. Not attempted: BaselineBroken
- Remaining d10a91879edd087b: NotRun. Not attempted: BaselineBroken
- Remaining 2d2689a322c7e19e: NotRun. Not attempted: BaselineBroken
- Remaining 19b878c24259941f: NotRun. Not attempted: BaselineBroken
- Remaining 545f03b948a7dd84: NotRun. Not attempted: BaselineBroken
- Remaining ab7ab6a2263e8671: NotRun. Not attempted: BaselineBroken
- Remaining 0c3ee63d3728df10: NotRun. Not attempted: BaselineBroken
- Remaining 4aa0efa9ce5f185f: NotRun. Not attempted: BaselineBroken
- Remaining 1cb4eab19f8e7ac5: NotRun. Not attempted: BaselineBroken
- Remaining 6f8deec927603eff: NotRun. Not attempted: BaselineBroken
- Remaining 9b146816513cce63: NotRun. Not attempted: BaselineBroken
- Remaining 3f6615eaaae3b323: NotRun. Not attempted: BaselineBroken
- Remaining e5ade81a833f76df: NotRun. Not attempted: BaselineBroken
- Remaining fa87e35b383db9d6: NotRun. Not attempted: BaselineBroken
- Remaining 0fa0c5d5cb290240: NotRun. Not attempted: BaselineBroken
- Remaining cc21ed7cc3dd791e: NotRun. Not attempted: BaselineBroken
- Remaining de999bf911d1224d: NotRun. Not attempted: BaselineBroken
- Remaining ee64a7888c26ea2a: NotRun. Not attempted: BaselineBroken
- Remaining d30b2567f5abb05b: NotRun. Not attempted: BaselineBroken
- Remaining 7969543de78c11e7: NotRun. Not attempted: BaselineBroken
- Remaining 1a1fbe65b34e37d7: NotRun. Not attempted: BaselineBroken
- Remaining 3563335d279bee97: NotRun. Not attempted: BaselineBroken
- Remaining 066ede9a860c4804: NotRun. Not attempted: BaselineBroken
- Remaining 6c1c0e3b609c9075: NotRun. Not attempted: BaselineBroken
- Remaining abd6044a64c3243a: NotRun. Not attempted: BaselineBroken
- Remaining 7046a8df3fc6300a: NotRun. Not attempted: BaselineBroken
- Remaining 6ba3c07cd2a832e6: NotRun. Not attempted: BaselineBroken
- Remaining 09612aa318484c7e: NotRun. Not attempted: BaselineBroken
- Remaining ebc9c57fec88bf7b: NotRun. Not attempted: BaselineBroken
- Remaining b65b202bf9e6563a: NotRun. Not attempted: BaselineBroken
- Remaining 5b3e033bac4376b6: NotRun. Not attempted: BaselineBroken
- Remaining 7fbed0b232922fb8: NotRun. Not attempted: BaselineBroken
- Remaining 2bd3115816f6d6dc: NotRun. Not attempted: BaselineBroken
- Remaining 0a85d8e44bf0263b: NotRun. Not attempted: BaselineBroken
- Remaining cf4876ba0957bfd5: NotRun. Not attempted: BaselineBroken
- Remaining ae83eeafe8201f45: NotRun. Not attempted: BaselineBroken
- Remaining 488556e5709c56c1: NotRun. Not attempted: BaselineBroken
- Remaining 2a8096040cd22804: NotRun. Not attempted: BaselineBroken
- Remaining ea3ceb6b2ca38548: NotRun. Not attempted: BaselineBroken
- Remaining 52f1dffdaf8a7109: NotRun. Not attempted: BaselineBroken
- Remaining f16d63de8ef7889c: NotRun. Not attempted: BaselineBroken
- Remaining 58a87350bd0072cd: NotRun. Not attempted: BaselineBroken
- Remaining a267fea12e49a017: NotRun. Not attempted: BaselineBroken
- Remaining db427bcd364fbaf7: NotRun. Not attempted: BaselineBroken
- Remaining 70cb005ada20d1ad: NotRun. Not attempted: BaselineBroken
- Remaining 4a683a2bc208f424: NotRun. Not attempted: BaselineBroken
- Remaining 87582096903996eb: NotRun. Not attempted: BaselineBroken
- Remaining efe623b676f3a1d7: NotRun. Not attempted: BaselineBroken
- Remaining c2806c1c39c26fde: NotRun. Not attempted: BaselineBroken
- Remaining 177b78aee529736f: NotRun. Not attempted: BaselineBroken
- Remaining ccf0fd8b99255371: NotRun. Not attempted: BaselineBroken
- Remaining 58eae44467107c8a: NotRun. Not attempted: BaselineBroken
- Remaining af52bcb9955678f9: NotRun. Not attempted: BaselineBroken
- Remaining 4ddef734f10c7968: NotRun. Not attempted: BaselineBroken
- Remaining ee8e81dc27856a8b: NotRun. Not attempted: BaselineBroken
- Remaining 81ac4a8d7fc2dc0e: NotRun. Not attempted: BaselineBroken
- Remaining cb69571e614de222: NotRun. Not attempted: BaselineBroken
- Remaining e88f9cdeab0c5905: NotRun. Not attempted: BaselineBroken
- Remaining fd2ca705d3101a96: NotRun. Not attempted: BaselineBroken
- Remaining 95cfa64f3f6a8b70: NotRun. Not attempted: BaselineBroken
- Remaining 37f01ad15e4c2f15: NotRun. Not attempted: BaselineBroken
- Remaining 93640cd352a2308d: NotRun. Not attempted: BaselineBroken
- Remaining b3284b4a11c8aabe: NotRun. Not attempted: BaselineBroken
- Remaining 592b20debdf92aff: NotRun. Not attempted: BaselineBroken
- Remaining edd95a119232c4a0: NotRun. Not attempted: BaselineBroken
- Remaining 577e606d117b6cec: NotRun. Not attempted: BaselineBroken
- Remaining cdb296ad8a743116: NotRun. Not attempted: BaselineBroken
- Remaining 9b6b0c7f8e7b39ae: NotRun. Not attempted: BaselineBroken
- Remaining 2f93f9e088525c10: NotRun. Not attempted: BaselineBroken
- Remaining c1ce18af99f6b38d: NotRun. Not attempted: BaselineBroken
- Remaining 05d805719bd1e94f: NotRun. Not attempted: BaselineBroken
- Remaining 5972ae0f1ef1292a: NotRun. Not attempted: BaselineBroken
- Remaining 8e412ba22783ab5c: NotRun. Not attempted: BaselineBroken
- Remaining 4dd61e79bb453e8d: NotRun. Not attempted: BaselineBroken
- Remaining cd4583b68bfaf5e5: NotRun. Not attempted: BaselineBroken
- Remaining 644ff2cb23bcdbc7: NotRun. Not attempted: BaselineBroken
- Remaining 0768c5feea498874: NotRun. Not attempted: BaselineBroken
- Remaining cb51831cd3b5d7e8: NotRun. Not attempted: BaselineBroken
- Remaining 03b161578fadadf5: NotRun. Not attempted: BaselineBroken
- Remaining aa2041fb2a54f6c4: NotRun. Not attempted: BaselineBroken
- Remaining e66e7741d89c858d: NotRun. Not attempted: BaselineBroken
- Remaining 78c3f2c78ee4036d: NotRun. Not attempted: BaselineBroken
- Remaining 175333449f8c1320: NotRun. Not attempted: BaselineBroken
- Remaining 9e5220dcaa3b02c3: NotRun. Not attempted: BaselineBroken
- Remaining 5fa8c3cdf13e3cec: NotRun. Not attempted: BaselineBroken
- Remaining d26ad17c45474533: NotRun. Not attempted: BaselineBroken
- Remaining 087ebc427703a03d: NotRun. Not attempted: BaselineBroken
- Remaining 1a5f8a72adfbbf58: NotRun. Not attempted: BaselineBroken
- Remaining cb4829db7b9c2afd: NotRun. Not attempted: BaselineBroken
- Remaining b8cd9c7a088f8edc: NotRun. Independent outcome evidence is required. Supply a checked workflow named 'decision:Suspending:desktop-lifecycle=window-close' or approve a criterion revision. Verify with build, launch, smoke. The work runs when the window closes, not when Windows suspends the app; ending the process abruptly does not run it.
- Unreported token, currency, CPU and memory fields are unknown, not zero.
- Process resources cover the direct child only, not its descendants or external agents.
- Declaration checks do not establish runtime or semantic equivalence. No new coverage is inferred.
- Hashes prove local consistency, not independent attestation. Review raw provenance before publishing.
