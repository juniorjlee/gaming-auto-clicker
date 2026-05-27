# PC Gaming Auto Clicker

![banner](https://raw.githubusercontent.com/juniorjlee/gaming-auto-clicker/main/assets/banner.png)

![Version](https://img.shields.io/badge/version-2.4.1-blue) ![Platform](https://img.shields.io/badge/platform-Windows-lightgrey) ![License](https://img.shields.io/badge/license-MIT-green)

**About**

I threw this together after one too many late-night sessions in MMOs where I was stuck spamming the same mouse button for hours just to finish daily rep grinds and world boss rotations. Simulator games made it worse—those resource nodes and idle loops that demand thousands of clicks before anything meaningful happens. I wanted something lightweight that could handle the repetition without turning my hand into a claw.

**Features**
- Record and replay click sequences with variable timing to match cooldowns in MMO skill rotations
- Pixel-based triggers for detecting loot windows or mob health bars during long farm sessions
- Per-profile CPS settings tuned for different simulator loops like ore runs or crafting macros
- Random delay injection between 80-220 ms to keep input patterns from looking scripted
- Global hotkey toggle that works even when the game is running borderless fullscreen
- Simple event logging so you can review click counts after multi-hour simulator grinds

**Requirements**
- Windows 10 or 11
- 4 GB RAM
- .NET 6.0 Desktop Runtime

**Installation**
1. Download the latest release from [GitHub Releases](https://github.com/juniorjlee/gaming-auto-clicker/releases/latest)
2. Extract the zip to any folder outside Program Files
3. Run GamingAutoClicker.exe and allow it through Windows Defender if prompted
4. Create a new profile and bind your preferred activation key

**Screenshots**

| Main Interface | Setup Wizard |
|----------------|--------------|
| ![main](https://raw.githubusercontent.com/juniorjlee/gaming-auto-clicker/main/assets/screenshot_main.png) | ![installer](https://raw.githubusercontent.com/juniorjlee/gaming-auto-clicker/main/assets/screenshot_installer.png) |
![app running](https://raw.githubusercontent.com/juniorjlee/gaming-auto-clicker/main/assets/screenshot_app.png)

**FAQ**

**Will this get me banned in online MMOs?**  
Most modern anti-cheats don’t flag simple input tools, but anything that runs while you’re AFK farming is still against ToS. I use randomized timing and only run it while at the keyboard.

**How do I set it up for a specific simulator?**  
Create a profile, set CPS to 12-15 for most idle loops, and use the color picker on the resource bar you want to keep clicking. Test in a short session first.

**Does it support multiple monitors?**  
Yes, but you have to pick the correct screen in the dropdown. Fullscreen exclusive games on the secondary monitor sometimes need borderless mode.

**Disclaimer**

This is a hobby project shared under MIT. Use it responsibly and respect each game’s terms of service. I’m not responsible for any account actions or hardware issues that result from its use.