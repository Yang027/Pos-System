大一程式設計專案：麥當勞Pos系統（非盈利功能）
==

`菜單`、`交易記錄`和`賬號存檔`都在PD2020S_Exmal_A108222027檔案下的`data`里<br>
`商品圖片`則在`info`下<br>
依照登陸的權限可以使用：`賬號管理`、`員工管理`、`點餐系統`、`店鋪管理`四個功能<br>
<br>
`賬號管理`:更改個人的賬號密碼和顯示名字,可查詢自己的交易記錄。權限:所有人<br>
`員工管理`:增加刪除修改員工,查看員工上線時間,離線時間,營銷額。權限:ower,admin<br>
`點餐系統`:分早餐時段和一般時段,早餐和一般時段都有外帶選項可選擇,一般時段可以使用甜心卡。權限:店員含以上<br>
`店鋪管理`:增加修改刪除商品的品項和內容,交易記錄的查詢,和銷售分析(圖表)。<br>
tip:<br>
每個功能需要load其對應的資料,不然無法讀取！<br>
密碼不可含有非法字元並且密碼長度必須超過4位數！<br>
<br>
有任何問題或是建議可以Email進行feedback!<br>
mail:y1595657589@gmail.com<br>

6.16更新說明：
--
1.新增賬號名稱限制，註冊或修改賬號名稱須大於4位數且不能有除了'_'外的特殊符號。<br>
2.移除原在order的上下箭頭將原本size變小<br>
3.order的地方新增清空全部商品<br>
4.銷售記錄查詢地方新增查詢外帶功能<br>
5.（修正order的可愛icon的返回主菜單功能）<br>
6.商品管理的為了提升ux修改了一些功能的位置。<br>
7.修正商品管理：新增、修改、刪除商品的bug<br>
8.修正Zedgraph的"產品"分析部分的數據<br>
9.商品的option選項防呆，最多只能選一個option <br>
6.19更新說明:
--
1.修改setup：賬號密碼姓名均要4~12位數切不能有非法字元<br>
2.修正breakfast點餐頁面顯示錯誤問題<br>
3.修改點餐頁面返回餐單的icon<br>
4.修改個人賬號修改及員工賬號修改的儲存鍵icon<br>
5.一些icons上新增加tooltips,給使用者在使用上提示。<br>
7.5更新說明：
--
1.窗體可以拖動、最小化和在工作列顯示<br>
