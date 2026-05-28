# BESOQ Games

CodeCanyon-dan əldə edilmiş Unity oyunlarının Play Store üçün uyğunlaşdırılmış kolleksiyası.

## Repository quruluşu

```
game/
├── .gitignore               # Unity və ümumi lazımsız faylları kənar tutur
├── README.md                # Bu fayl
└── LastDrive/               # Oyun #1 — Car vs Cops (Unity 3D)
    ├── Assets/
    ├── Packages/
    ├── ProjectSettings/
    └── Documentation/
```

## Oyunlar

### 1. LastDrive
- **Mənbə:** CodeCanyon (CarVsCops v1.1)
- **Şirkət:** BESOQ
- **Engine:** Unity 2019.4.30f1 LTS
- **Render Pipeline:** Universal RP (URP) 7.6.0
- **Platforma:** Android (Mobile)
- **Oriyentasiya:** Portrait
- **Reklam SDK:** AdMob + Unity Ads + GDPR razılığı

#### Əsas asılılıqlar (Packages/manifest.json)
- `com.unity.ads` 3.7.5
- `com.unity.render-pipelines.universal` 7.6.0
- `com.unity.textmeshpro` 2.1.4

#### Səhnələr
- `Assets/_Game/Scenes/Game.unity` — əsas oyun
- `Assets/_Ads/_GDPR/GDPR.unity` — GDPR razılıq ekranı

## Növbəti addımlar

- [ ] Package name dəyişdir (məs: `com.besoq.lastdrive`)
- [ ] AdMob App ID və Ad Unit ID-ləri öz hesabınla əvəzlə
- [ ] Şirkət/məhsul adlarını yenilə
- [ ] Splash screen və ikon dəyiş
- [ ] Keystore yarat (release imza üçün)
- [ ] Play Store metadata (screenshot, description) hazırla

## Lisenziya qeydi

Oyunlar CodeCanyon Regular/Extended lisenziyası altında alınmışdır.
Play Store-a yükləməzdən əvvəl lisenziya şərtlərini yoxlayın.
