# MuBa Games

CodeCanyon-dan əldə edilmiş Unity oyunlarının Play Store üçün uyğunlaşdırılmış kolleksiyası.

## Repository quruluşu

```
game/
├── .gitignore               # Unity və ümumi lazımsız faylları kənar tutur
├── README.md                # Bu fayl
└── LastDrive/               # Oyun #1 — LastDrive (Unity 3D)
    ├── Assets/
    ├── Packages/
    ├── ProjectSettings/
    └── Documentation/
```

## Oyunlar

### 1. LastDrive
- **Developer:** MuBa Games
- **Mənbə:** CodeCanyon (orijinal: CarVsCops v1.1)
- **Package name:** `com.mubagames.lastdrive`
- **Engine:** Unity 2019.4.30f1 LTS
- **Render Pipeline:** Universal RP (URP) 7.6.0
- **Platforma:** Android (Mobile)
- **Oriyentasiya:** Portrait
- **Reklam SDK:** AdMob + Unity Ads + GDPR razılığı

#### AdMob konfiqurasiyası
- **App ID:** `ca-app-pub-2121166615688784~8082114112`
- **Banner:** `ca-app-pub-2121166615688784/6495597482`
- **Interstitial:** `ca-app-pub-2121166615688784/3869434145`
- **Rewarded:** `ca-app-pub-2121166615688784/3532872315`

#### Əsas asılılıqlar (Packages/manifest.json)
- `com.unity.ads` 3.7.5
- `com.unity.render-pipelines.universal` 7.6.0
- `com.unity.textmeshpro` 2.1.4

#### Səhnələr
- `Assets/_Game/Scenes/Game.unity` — əsas oyun
- `Assets/_Ads/_GDPR/GDPR.unity` — GDPR razılıq ekranı

## Növbəti addımlar

- [x] Package name dəyişdirildi (`com.mubagames.lastdrive`)
- [x] Şirkət adı yeniləndi (`MuBa Games`)
- [x] AdMob App ID və Ad Unit ID-ləri quraşdırıldı
- [ ] Splash screen və ikon dəyiş
- [ ] Keystore yarat (release imza üçün)
- [ ] AdMob ödəniş profili tamamla
- [ ] Play Store metadata (screenshot, description) hazırla

## Lisenziya qeydi

Oyunlar CodeCanyon Regular/Extended lisenziyası altında alınmışdır.
Play Store-a yükləməzdən əvvəl lisenziya şərtlərini yoxlayın.
