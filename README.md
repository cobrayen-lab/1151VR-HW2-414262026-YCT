### GitHub 連結 : https://github.com/cobrayen-lab/1151VR-HW2-414262026-YCT

### YouTube 連結 : https://youtu.be/Sl4oFw9sv1w

### 製作流程 : 
  - **建立遊戲場景** :
    首先建立 Unity 2D 專案，將角色圖片匯入專案中，並建立地面、平台及終點（Finish），作為角色移動、跳躍和抵達終點的場景。
  - **設定角色** : 
    為角色加入 Rigidbody2D 和 Collider2D，讓角色可以受到重力影響，並與地面及平台產生碰撞。接著撰寫 C# 程式，讓角色可以左右移動及跳躍，並根據移動方向切換圖片的朝向。
      - 右走 : <img width="426" height="158" alt="right" src="https://github.com/user-attachments/assets/bbfe1d57-eab5-47a6-8ea5-45d5d6c9bcb9" />
      - 左走 : <img width="435" height="185" alt="left" src="https://github.com/user-attachments/assets/12acdfdb-24b0-4230-946b-4ff91d71ff46" />


  - **設定平台** : 
    在場景中放置平台，讓角色可以透過跳躍到達平台並繼續前進。程式中使用 Vector2 陣列儲存平台的位置，並透過迴圈和 Instantiate() 建立平台。
  - **設定終點與遊戲結果** : 
    為 Finish 加入碰撞偵測，當角色碰到終點時，畫面會顯示「You Win!」。另外，也設定角色掉落到指定高度以下時，畫面會顯示「You Lose!」，等待兩秒後重新載入場景，讓玩家可以再次挑戰。
    - You Win! : <img width="410" height="192" alt="win" src="https://github.com/user-attachments/assets/5840bc8d-dff5-4602-bfe2-4dfd3bf7bc67" />

    - You Lose! : <img width="430" height="175" alt="lose" src="https://github.com/user-attachments/assets/3bc8cde5-5de3-4e37-97dc-cbf9dc187783" />

  - **測試與調整** :
    完成程式後，實際執行遊戲，測試角色的移動、跳躍、平台碰撞、終點偵測及掉落後重新開始等功能，並依照測試結果調整相關設定。

### 遊戲操作 :
  - 向左移動： 按下 A 鍵或鍵盤左方向鍵。
  - 向右移動： 按下 D 鍵或鍵盤右方向鍵。
  - 跳躍： 按下 Space（空白鍵）。
  - 遊戲勝利： 成功抵達 Finish 時，畫面會顯示「You Win!」。
  - 遊戲失敗： 角色掉落到場景下方時，畫面會顯示「You Lose!」，等待兩秒後自動重新開始。

遊戲的目標是控制角色移動，順利抵達終點。如果不小心掉落，也可以重新挑戰，直到成功抵達 Finish。
