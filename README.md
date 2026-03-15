# Unity Card Game Project

Unity를 사용하여 카드 게임의 기본 시스템을 구현해보는 프로젝트입니다.
카드 드로우, 손패 관리, 카드 사용 등 카드 게임의 핵심 구조를 직접 구현하면서 Unity UI 시스템과 C# 스크립트 구조를 학습하는 것을 목표로 했습니다.

---

## 프로젝트 목표

카드 게임의 기본적인 흐름을 직접 구현하면서 다음과 같은 구조를 이해하는 것을 목표로 했습니다.

* 덱(Deck)에서 카드 드로우
* 손패(Hand)에 카드 생성
* 카드 클릭을 통한 효과 실행
* 적에게 데미지 적용

---

## 구현 기능

### 1. 카드 데이터 구조

카드의 이름, 비용, 데미지 등의 정보를 관리하기 위해 `CardData` 클래스를 사용했습니다.

카드의 실제 로직과 데이터를 분리하는 구조를 사용했습니다.

예시 정보

* Card Name
* Cost
* Damage
* Artwork

---

### 2. 덱 시스템 (Deck System)

`DeckManager`를 통해 덱에서 카드를 한 장씩 뽑는 기능을 구현했습니다.

구현 내용

* 카드 리스트 관리
* 카드 드로우 함수
* 덱에서 카드 제거

```text
Deck → Draw → CardData 반환
```

---

### 3. 손패 시스템 (Hand System)

`HandManager`를 사용하여 손패 영역에 카드를 생성하도록 구현했습니다.

구현 방식

* Card Prefab 생성
* Instantiate를 이용한 카드 UI 생성
* HandArea에 카드 배치

```text
DeckManager
     ↓
Draw
     ↓
HandManager
     ↓
Card Prefab 생성
```

---

### 4. 카드 UI 구성

Unity UI 시스템을 이용하여 카드 형태의 UI를 구성했습니다.

사용 요소

* Canvas
* Image
* TextMeshPro
* Button

카드 UI는 Prefab으로 관리하여 코드에서 생성할 수 있도록 구성했습니다.

---

### 5. 카드 클릭 시스템

카드를 클릭하면 카드 효과가 실행되도록 구현했습니다.

구현 방식

* Button 컴포넌트 사용
* OnClick 이벤트 연결
* Card 스크립트에서 카드 로직 처리

```text
Card Click
    ↓
Enemy.TakeDamage()
    ↓
Card Destroy
```

---

### 6. Enemy 시스템

Enemy 오브젝트를 만들고 체력을 관리하는 간단
