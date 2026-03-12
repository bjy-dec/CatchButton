# 버튼잡기게임(C# 코딩)
## 개요
- C# 프로그래밍학습
- -핵심기능: 마우스를 피하는 버튼을 클릭하는 게임
-           -점수 표시 가능
-           -버튼 클릭시 버튼 크기를 축소시켜 난이도 상향
-           -20회 이상 클릭하지 못할시 게임 오버
-           -재시작 버튼 활성화
- -화면구성: 클릭해야 하는 버튼과 재시작 버튼으로 간단하게 구성하였고 점수와 버튼 좌표는 폼 제목에 고정시킴
-
-
- ## 실행화면
- -1단계코드의실행스크린샷
- <img width="798" height="480" alt="버튼 랜덤 위치" src="https://github.com/user-attachments/assets/7e06b5e8-bbec-445c-b72d-a317e300d4d1" />
- <img width="800" height="476" alt="버튼 랜덤 위치(2)" src="https://github.com/user-attachments/assets/793880c9-8935-4e3e-8f0d-47ccf1614333" />
-  --> 마우스를 버튼 위로 옮길시 버튼 위치 랜덤 변경 및 랜덤 좌표 설정
- 2단계코드의실행스크린샷
-<img width="800" height="480" alt="버튼 클릭 성공" src="https://github.com/user-attachments/assets/30400ae7-00a2-4d13-8a67-3a638978503d" />
-  --> 버튼 클릭 성공 시 성공 메시지 삽입
- -3단계코드의실행스크린샷
-<img width="800" height="478" alt="점수 표시 수정" src="https://github.com/user-attachments/assets/1bedeabe-2169-40b6-b05f-fda3e5f2483f" />
-<img width="799" height="477" alt="버튼 -" src="https://github.com/user-attachments/assets/6853a4be-72fa-40ce-bbc4-d05a3549b45d" />
-  --> 버튼 클릭 성공 점수와 실패 점수 계산하여 폼 제목에 표시
<img width="801" height="475" alt="버튼 크기 조절" src="https://github.com/user-attachments/assets/8ee42e1e-ad84-4cf5-b02d-ff21fa63c6fa" />
-  --> 버튼 클릭 성공시 버튼 크기를 5%씩 축소

- -4단계코드의실행스크린샷
<img width="800" height="479" alt="게 임오버" src="https://github.com/user-attachments/assets/ee01796c-3e6d-41a2-9df2-83201dde1f6c" />
-  --> 게임 오버 표시하기
<img width="798" height="476" alt="재시작 버튼" src="https://github.com/user-attachments/assets/b7721690-826a-4ae4-8044-69cbfafd8052" />
-  --> 재시작 버튼 구현
<img width="800" height="479" alt="재시 작완" src="https://github.com/user-attachments/assets/be6b9433-898f-4511-baa2-f9c082466fd7" />
-  --> 재시작 버튼 눌렀을 때 초기 모습으로 돌아가는 모습



- ## 구현시어려웠던점
- 
-  점수를 폼 제목에 표시할 때 좌표가 사라지는 문제가 발생했을때 좌표와 점수를 같이 입력하여 해결할 수 있었음
-  재시작 버튼을 눌렀을때 클릭해야 하는 버튼이 보이지 않는 문제가 발생했음 --> 재시작 버튼에 mybutton.Visible 를 true 설정
