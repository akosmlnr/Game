using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004C8 RID: 1224
	public class PlayingCard : MonoBehaviour
	{
		// Token: 0x060069AF RID: 27055 RVA: 0x001DD038 File Offset: 0x001DB238
		// Note: this type is marked as 'beforefieldinit'.
		static PlayingCard()
		{
			Il2CppClassPointerStore<PlayingCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "PlayingCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr);
			PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<IsFaceUp>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<Suit>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<Value>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<CardController>k__BackingField");
			PlayingCard.NativeFieldInfoPtr_CardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardID");
			PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSpriteRenderer");
			PlayingCard.NativeFieldInfoPtr_CardSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSprites");
			PlayingCard.NativeFieldInfoPtr_FlipAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipAnimation");
			PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipFaceUpClip");
			PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipFaceDownClip");
			PlayingCard.NativeFieldInfoPtr_FlipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipSound");
			PlayingCard.NativeFieldInfoPtr_LandSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "LandSound");
			PlayingCard.NativeFieldInfoPtr_moveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "moveRoutine");
			PlayingCard.NativeFieldInfoPtr_lastGlideTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "lastGlideTarget");
			PlayingCard.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676809);
			PlayingCard.NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676810);
			PlayingCard.NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676811);
			PlayingCard.NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676812);
			PlayingCard.NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676813);
			PlayingCard.NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676814);
			PlayingCard.NativeMethodInfoPtr_get_CardController_Public_get_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676815);
			PlayingCard.NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676816);
			PlayingCard.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676817);
			PlayingCard.NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676818);
			PlayingCard.NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676819);
			PlayingCard.NativeMethodInfoPtr_ClearCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676820);
			PlayingCard.NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676821);
			PlayingCard.NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676822);
			PlayingCard.NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676823);
			PlayingCard.NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676824);
			PlayingCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676825);
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x060069B0 RID: 27056 RVA: 0x001DD2D4 File Offset: 0x001DB4D4
		// (set) Token: 0x060069B1 RID: 27057 RVA: 0x001DD310 File Offset: 0x001DB510
		public unsafe bool IsFaceUp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x060069B2 RID: 27058 RVA: 0x001DD350 File Offset: 0x001DB550
		// (set) Token: 0x060069B3 RID: 27059 RVA: 0x001DD38C File Offset: 0x001DB58C
		public unsafe PlayingCard.ECardSuit Suit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31397, RefRangeEnd = 31398, XrefRangeStart = 31397, XrefRangeEnd = 31398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x060069B4 RID: 27060 RVA: 0x001DD3CC File Offset: 0x001DB5CC
		// (set) Token: 0x060069B5 RID: 27061 RVA: 0x001DD408 File Offset: 0x001DB608
		public unsafe PlayingCard.ECardValue Value
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 31426, RefRangeEnd = 31454, XrefRangeStart = 31426, XrefRangeEnd = 31454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31454, RefRangeEnd = 31455, XrefRangeStart = 31454, XrefRangeEnd = 31455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x060069B6 RID: 27062 RVA: 0x001DD448 File Offset: 0x001DB648
		// (set) Token: 0x060069B7 RID: 27063 RVA: 0x001DD488 File Offset: 0x001DB688
		public unsafe CardController CardController
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_CardController_Public_get_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x001DD4CC File Offset: 0x001DB6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214574, XrefRangeEnd = 214582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x001DD500 File Offset: 0x001DB700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardController(CardController cardController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardController);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x001DD544 File Offset: 0x001DB744
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 214587, RefRangeEnd = 214591, XrefRangeStart = 214582, XrefRangeEnd = 214587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCard(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref suit;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x001DD5A0 File Offset: 0x001DB7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214591, XrefRangeEnd = 214592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_ClearCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x001DD5D4 File Offset: 0x001DB7D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 214600, RefRangeEnd = 214608, XrefRangeStart = 214592, XrefRangeEnd = 214600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceUp(bool faceUp, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref faceUp;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x001DD620 File Offset: 0x001DB820
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 214622, RefRangeEnd = 214632, XrefRangeStart = 214608, XrefRangeEnd = 214622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x001DD688 File Offset: 0x001DB888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214646, RefRangeEnd = 214647, XrefRangeStart = 214632, XrefRangeEnd = 214646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard.CardSprite GetCardSprite(PlayingCard.ECardSuit suit, PlayingCard.ECardValue val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref suit;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref val;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard.CardSprite>(intPtr2) : null;
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x001DD6E4 File Offset: 0x001DB8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214647, XrefRangeEnd = 214727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyCardSprites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x001DD718 File Offset: 0x001DB918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214727, XrefRangeEnd = 214732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x000319A0 File Offset: 0x0002FBA0
		public PlayingCard(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x060069C2 RID: 27074 RVA: 0x001DD754 File Offset: 0x001DB954
		// (set) Token: 0x060069C3 RID: 27075 RVA: 0x000319A9 File Offset: 0x0002FBA9
		public unsafe bool _IsFaceUp_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x060069C4 RID: 27076 RVA: 0x001DD77C File Offset: 0x001DB97C
		// (set) Token: 0x060069C5 RID: 27077 RVA: 0x000319C4 File Offset: 0x0002FBC4
		public unsafe PlayingCard.ECardSuit _Suit_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x060069C6 RID: 27078 RVA: 0x001DD7A4 File Offset: 0x001DB9A4
		// (set) Token: 0x060069C7 RID: 27079 RVA: 0x000319DF File Offset: 0x0002FBDF
		public unsafe PlayingCard.ECardValue _Value_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x060069C8 RID: 27080 RVA: 0x001DD7CC File Offset: 0x001DB9CC
		// (set) Token: 0x060069C9 RID: 27081 RVA: 0x000319FA File Offset: 0x0002FBFA
		public unsafe CardController _CardController_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x060069CA RID: 27082 RVA: 0x001DD7FC File Offset: 0x001DB9FC
		// (set) Token: 0x060069CB RID: 27083 RVA: 0x00031A19 File Offset: 0x0002FC19
		public unsafe string CardID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x060069CC RID: 27084 RVA: 0x001DD824 File Offset: 0x001DBA24
		// (set) Token: 0x060069CD RID: 27085 RVA: 0x00031A38 File Offset: 0x0002FC38
		public unsafe SpriteRenderer CardSpriteRenderer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x060069CE RID: 27086 RVA: 0x001DD854 File Offset: 0x001DBA54
		// (set) Token: 0x060069CF RID: 27087 RVA: 0x00031A57 File Offset: 0x0002FC57
		public unsafe Il2CppReferenceArray<PlayingCard.CardSprite> CardSprites
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSprites);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard.CardSprite>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x060069D0 RID: 27088 RVA: 0x001DD884 File Offset: 0x001DBA84
		// (set) Token: 0x060069D1 RID: 27089 RVA: 0x00031A76 File Offset: 0x0002FC76
		public unsafe Animation FlipAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x001DD8B4 File Offset: 0x001DBAB4
		// (set) Token: 0x060069D3 RID: 27091 RVA: 0x00031A95 File Offset: 0x0002FC95
		public unsafe AnimationClip FlipFaceUpClip
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x060069D4 RID: 27092 RVA: 0x001DD8E4 File Offset: 0x001DBAE4
		// (set) Token: 0x060069D5 RID: 27093 RVA: 0x00031AB4 File Offset: 0x0002FCB4
		public unsafe AnimationClip FlipFaceDownClip
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x060069D6 RID: 27094 RVA: 0x001DD914 File Offset: 0x001DBB14
		// (set) Token: 0x060069D7 RID: 27095 RVA: 0x00031AD3 File Offset: 0x0002FCD3
		public unsafe AudioSourceController FlipSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x001DD944 File Offset: 0x001DBB44
		// (set) Token: 0x060069D9 RID: 27097 RVA: 0x00031AF2 File Offset: 0x0002FCF2
		public unsafe AudioSourceController LandSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_LandSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_LandSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x060069DA RID: 27098 RVA: 0x001DD974 File Offset: 0x001DBB74
		// (set) Token: 0x060069DB RID: 27099 RVA: 0x00031B11 File Offset: 0x0002FD11
		public unsafe Coroutine moveRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_moveRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_moveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x060069DC RID: 27100 RVA: 0x001DD9A4 File Offset: 0x001DBBA4
		// (set) Token: 0x060069DD RID: 27101 RVA: 0x00031B30 File Offset: 0x0002FD30
		public unsafe Il2CppSystem.Tuple<Vector3, Quaternion> lastGlideTarget
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_lastGlideTarget);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Tuple<Vector3, Quaternion>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_lastGlideTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004868 RID: 18536
		private static readonly System.IntPtr NativeFieldInfoPtr__IsFaceUp_k__BackingField;

		// Token: 0x04004869 RID: 18537
		private static readonly System.IntPtr NativeFieldInfoPtr__Suit_k__BackingField;

		// Token: 0x0400486A RID: 18538
		private static readonly System.IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x0400486B RID: 18539
		private static readonly System.IntPtr NativeFieldInfoPtr__CardController_k__BackingField;

		// Token: 0x0400486C RID: 18540
		private static readonly System.IntPtr NativeFieldInfoPtr_CardID;

		// Token: 0x0400486D RID: 18541
		private static readonly System.IntPtr NativeFieldInfoPtr_CardSpriteRenderer;

		// Token: 0x0400486E RID: 18542
		private static readonly System.IntPtr NativeFieldInfoPtr_CardSprites;

		// Token: 0x0400486F RID: 18543
		private static readonly System.IntPtr NativeFieldInfoPtr_FlipAnimation;

		// Token: 0x04004870 RID: 18544
		private static readonly System.IntPtr NativeFieldInfoPtr_FlipFaceUpClip;

		// Token: 0x04004871 RID: 18545
		private static readonly System.IntPtr NativeFieldInfoPtr_FlipFaceDownClip;

		// Token: 0x04004872 RID: 18546
		private static readonly System.IntPtr NativeFieldInfoPtr_FlipSound;

		// Token: 0x04004873 RID: 18547
		private static readonly System.IntPtr NativeFieldInfoPtr_LandSound;

		// Token: 0x04004874 RID: 18548
		private static readonly System.IntPtr NativeFieldInfoPtr_moveRoutine;

		// Token: 0x04004875 RID: 18549
		private static readonly System.IntPtr NativeFieldInfoPtr_lastGlideTarget;

		// Token: 0x04004876 RID: 18550
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0;

		// Token: 0x04004877 RID: 18551
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0;

		// Token: 0x04004878 RID: 18552
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0;

		// Token: 0x04004879 RID: 18553
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0;

		// Token: 0x0400487A RID: 18554
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0;

		// Token: 0x0400487B RID: 18555
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0;

		// Token: 0x0400487C RID: 18556
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CardController_Public_get_CardController_0;

		// Token: 0x0400487D RID: 18557
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0;

		// Token: 0x0400487E RID: 18558
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400487F RID: 18559
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0;

		// Token: 0x04004880 RID: 18560
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0;

		// Token: 0x04004881 RID: 18561
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearCard_Public_Void_0;

		// Token: 0x04004882 RID: 18562
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004883 RID: 18563
		private static readonly System.IntPtr NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0;

		// Token: 0x04004884 RID: 18564
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0;

		// Token: 0x04004885 RID: 18565
		private static readonly System.IntPtr NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0;

		// Token: 0x04004886 RID: 18566
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A8F RID: 2703
		[System.Serializable]
		public class CardSprite : Il2CppSystem.Object
		{
			// Token: 0x0600D50F RID: 54543 RVA: 0x00334514 File Offset: 0x00332714
			// Note: this type is marked as 'beforefieldinit'.
			static CardSprite()
			{
				Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSprite");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr);
				PlayingCard.CardSprite.NativeFieldInfoPtr_Suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Suit");
				PlayingCard.CardSprite.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Value");
				PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Sprite");
				PlayingCard.CardSprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, 100676826);
			}

			// Token: 0x0600D510 RID: 54544 RVA: 0x00334590 File Offset: 0x00332790
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardSprite() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.CardSprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D511 RID: 54545 RVA: 0x00067567 File Offset: 0x00065767
			public CardSprite(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041DF RID: 16863
			// (get) Token: 0x0600D512 RID: 54546 RVA: 0x003345CC File Offset: 0x003327CC
			// (set) Token: 0x0600D513 RID: 54547 RVA: 0x00067570 File Offset: 0x00065770
			public unsafe PlayingCard.ECardSuit Suit
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Suit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Suit)) = value;
				}
			}

			// Token: 0x170041E0 RID: 16864
			// (get) Token: 0x0600D514 RID: 54548 RVA: 0x003345F4 File Offset: 0x003327F4
			// (set) Token: 0x0600D515 RID: 54549 RVA: 0x0006758B File Offset: 0x0006578B
			public unsafe PlayingCard.ECardValue Value
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x170041E1 RID: 16865
			// (get) Token: 0x0600D516 RID: 54550 RVA: 0x0033461C File Offset: 0x0033281C
			// (set) Token: 0x0600D517 RID: 54551 RVA: 0x000675A6 File Offset: 0x000657A6
			public unsafe Sprite Sprite
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FBA RID: 36794
			private static readonly System.IntPtr NativeFieldInfoPtr_Suit;

			// Token: 0x04008FBB RID: 36795
			private static readonly System.IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008FBC RID: 36796
			private static readonly System.IntPtr NativeFieldInfoPtr_Sprite;

			// Token: 0x04008FBD RID: 36797
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A90 RID: 2704
		[StructLayout(LayoutKind.Explicit)]
		public struct CardData
		{
			// Token: 0x0600D518 RID: 54552 RVA: 0x0033464C File Offset: 0x0033284C
			// Note: this type is marked as 'beforefieldinit'.
			static CardData()
			{
				Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr);
				PlayingCard.CardData.NativeFieldInfoPtr_Suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, "Suit");
				PlayingCard.CardData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, "Value");
				PlayingCard.CardData.NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, 100676827);
			}

			// Token: 0x0600D519 RID: 54553 RVA: 0x003346B4 File Offset: 0x003328B4
			[CallerCount(486)]
			[CachedScanResults(RefRangeStart = 35745, RefRangeEnd = 36231, XrefRangeStart = 35745, XrefRangeEnd = 36231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardData(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref suit;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.CardData.NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0, ref this, (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D51A RID: 54554 RVA: 0x000675C5 File Offset: 0x000657C5
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, ref this));
			}

			// Token: 0x04008FBE RID: 36798
			private static readonly System.IntPtr NativeFieldInfoPtr_Suit;

			// Token: 0x04008FBF RID: 36799
			private static readonly System.IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008FC0 RID: 36800
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0;

			// Token: 0x04008FC1 RID: 36801
			[FieldOffset(0)]
			public PlayingCard.ECardSuit Suit;

			// Token: 0x04008FC2 RID: 36802
			[FieldOffset(4)]
			public PlayingCard.ECardValue Value;
		}

		// Token: 0x02000A91 RID: 2705
		[OriginalName("Assembly-CSharp.dll", "", "ECardSuit")]
		public enum ECardSuit
		{
			// Token: 0x04008FC4 RID: 36804
			Spades,
			// Token: 0x04008FC5 RID: 36805
			Hearts,
			// Token: 0x04008FC6 RID: 36806
			Diamonds,
			// Token: 0x04008FC7 RID: 36807
			Clubs
		}

		// Token: 0x02000A92 RID: 2706
		[OriginalName("Assembly-CSharp.dll", "", "ECardValue")]
		public enum ECardValue
		{
			// Token: 0x04008FC9 RID: 36809
			Blank,
			// Token: 0x04008FCA RID: 36810
			Ace,
			// Token: 0x04008FCB RID: 36811
			Two,
			// Token: 0x04008FCC RID: 36812
			Three,
			// Token: 0x04008FCD RID: 36813
			Four,
			// Token: 0x04008FCE RID: 36814
			Five,
			// Token: 0x04008FCF RID: 36815
			Six,
			// Token: 0x04008FD0 RID: 36816
			Seven,
			// Token: 0x04008FD1 RID: 36817
			Eight,
			// Token: 0x04008FD2 RID: 36818
			Nine,
			// Token: 0x04008FD3 RID: 36819
			Ten,
			// Token: 0x04008FD4 RID: 36820
			Jack,
			// Token: 0x04008FD5 RID: 36821
			Queen,
			// Token: 0x04008FD6 RID: 36822
			King
		}

		// Token: 0x02000A93 RID: 2707
		[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D51B RID: 54555 RVA: 0x003346F4 File Offset: 0x003328F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr);
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "duration");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "position");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "verticalOffset");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "rotation");
				PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, 100676828);
				PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, 100676829);
			}

			// Token: 0x0600D51C RID: 54556 RVA: 0x003347AC File Offset: 0x003329AC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D51D RID: 54557 RVA: 0x003347E8 File Offset: 0x003329E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214569, XrefRangeEnd = 214574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D51E RID: 54558 RVA: 0x000675D7 File Offset: 0x000657D7
			public __c__DisplayClass35_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041E2 RID: 16866
			// (get) Token: 0x0600D51F RID: 54559 RVA: 0x00334828 File Offset: 0x00332A28
			// (set) Token: 0x0600D520 RID: 54560 RVA: 0x000675E0 File Offset: 0x000657E0
			public unsafe PlayingCard __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E3 RID: 16867
			// (get) Token: 0x0600D521 RID: 54561 RVA: 0x00334858 File Offset: 0x00332A58
			// (set) Token: 0x0600D522 RID: 54562 RVA: 0x000675FF File Offset: 0x000657FF
			public unsafe float duration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170041E4 RID: 16868
			// (get) Token: 0x0600D523 RID: 54563 RVA: 0x00334880 File Offset: 0x00332A80
			// (set) Token: 0x0600D524 RID: 54564 RVA: 0x0006761A File Offset: 0x0006581A
			public unsafe Vector3 position
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x170041E5 RID: 16869
			// (get) Token: 0x0600D525 RID: 54565 RVA: 0x003348A8 File Offset: 0x00332AA8
			// (set) Token: 0x0600D526 RID: 54566 RVA: 0x00067635 File Offset: 0x00065835
			public unsafe float verticalOffset
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset)) = value;
				}
			}

			// Token: 0x170041E6 RID: 16870
			// (get) Token: 0x0600D527 RID: 54567 RVA: 0x003348D0 File Offset: 0x00332AD0
			// (set) Token: 0x0600D528 RID: 54568 RVA: 0x00067650 File Offset: 0x00065850
			public unsafe Quaternion rotation
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x04008FD7 RID: 36823
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FD8 RID: 36824
			private static readonly System.IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008FD9 RID: 36825
			private static readonly System.IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04008FDA RID: 36826
			private static readonly System.IntPtr NativeFieldInfoPtr_verticalOffset;

			// Token: 0x04008FDB RID: 36827
			private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04008FDC RID: 36828
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FDD RID: 36829
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CB5 RID: 3253
			[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass35_0+<<GlideTo>g__MoveRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E944 RID: 59716 RVA: 0x0036DC84 File Offset: 0x0036BE84
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique()
				{
					Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "<<GlideTo>g__MoveRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<startPosition>5__2");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<startRotation>5__3");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<time>5__4");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676830);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676831);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676832);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676833);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676834);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676835);
				}

				// Token: 0x0600E945 RID: 59717 RVA: 0x0036DDA0 File Offset: 0x0036BFA0
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E946 RID: 59718 RVA: 0x0036DDE8 File Offset: 0x0036BFE8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E947 RID: 59719 RVA: 0x0036DE1C File Offset: 0x0036C01C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214544, XrefRangeEnd = 214564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004818 RID: 18456
				// (get) Token: 0x0600E948 RID: 59720 RVA: 0x0036DE58 File Offset: 0x0036C058
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E949 RID: 59721 RVA: 0x0036DE98 File Offset: 0x0036C098
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214564, XrefRangeEnd = 214569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004819 RID: 18457
				// (get) Token: 0x0600E94A RID: 59722 RVA: 0x0036DECC File Offset: 0x0036C0CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E94B RID: 59723 RVA: 0x00071646 File Offset: 0x0006F846
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004812 RID: 18450
				// (get) Token: 0x0600E94C RID: 59724 RVA: 0x0036DF0C File Offset: 0x0036C10C
				// (set) Token: 0x0600E94D RID: 59725 RVA: 0x0007164F File Offset: 0x0006F84F
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004813 RID: 18451
				// (get) Token: 0x0600E94E RID: 59726 RVA: 0x0036DF34 File Offset: 0x0036C134
				// (set) Token: 0x0600E94F RID: 59727 RVA: 0x0007166A File Offset: 0x0006F86A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004814 RID: 18452
				// (get) Token: 0x0600E950 RID: 59728 RVA: 0x0036DF64 File Offset: 0x0036C164
				// (set) Token: 0x0600E951 RID: 59729 RVA: 0x00071689 File Offset: 0x0006F889
				public unsafe PlayingCard.__c__DisplayClass35_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004815 RID: 18453
				// (get) Token: 0x0600E952 RID: 59730 RVA: 0x0036DF94 File Offset: 0x0036C194
				// (set) Token: 0x0600E953 RID: 59731 RVA: 0x000716A8 File Offset: 0x0006F8A8
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x17004816 RID: 18454
				// (get) Token: 0x0600E954 RID: 59732 RVA: 0x0036DFBC File Offset: 0x0036C1BC
				// (set) Token: 0x0600E955 RID: 59733 RVA: 0x000716C3 File Offset: 0x0006F8C3
				public unsafe Quaternion _startRotation_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3)) = value;
					}
				}

				// Token: 0x17004817 RID: 18455
				// (get) Token: 0x0600E956 RID: 59734 RVA: 0x0036DFE4 File Offset: 0x0036C1E4
				// (set) Token: 0x0600E957 RID: 59735 RVA: 0x000716DE File Offset: 0x0006F8DE
				public unsafe float _time_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4)) = value;
					}
				}

				// Token: 0x04009C20 RID: 39968
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C21 RID: 39969
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C22 RID: 39970
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C23 RID: 39971
				private static readonly System.IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x04009C24 RID: 39972
				private static readonly System.IntPtr NativeFieldInfoPtr__startRotation_5__3;

				// Token: 0x04009C25 RID: 39973
				private static readonly System.IntPtr NativeFieldInfoPtr__time_5__4;

				// Token: 0x04009C26 RID: 39974
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C27 RID: 39975
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C28 RID: 39976
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C29 RID: 39977
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C2A RID: 39978
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C2B RID: 39979
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A94 RID: 2708
		[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D529 RID: 54569 RVA: 0x003348F8 File Offset: 0x00332AF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr);
				PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, "suit");
				PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, "val");
				PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, 100676836);
				PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, 100676837);
			}

			// Token: 0x0600D52A RID: 54570 RVA: 0x00334974 File Offset: 0x00332B74
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D52B RID: 54571 RVA: 0x003349B0 File Offset: 0x00332BB0
			[CallerCount(0)]
			public unsafe bool _GetCardSprite_b__0(PlayingCard.CardSprite x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D52C RID: 54572 RVA: 0x0006766B File Offset: 0x0006586B
			public __c__DisplayClass36_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041E7 RID: 16871
			// (get) Token: 0x0600D52D RID: 54573 RVA: 0x00334A00 File Offset: 0x00332C00
			// (set) Token: 0x0600D52E RID: 54574 RVA: 0x00067674 File Offset: 0x00065874
			public unsafe PlayingCard.ECardSuit suit
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit)) = value;
				}
			}

			// Token: 0x170041E8 RID: 16872
			// (get) Token: 0x0600D52F RID: 54575 RVA: 0x00334A28 File Offset: 0x00332C28
			// (set) Token: 0x0600D530 RID: 54576 RVA: 0x0006768F File Offset: 0x0006588F
			public unsafe PlayingCard.ECardValue val
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x04008FDE RID: 36830
			private static readonly System.IntPtr NativeFieldInfoPtr_suit;

			// Token: 0x04008FDF RID: 36831
			private static readonly System.IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04008FE0 RID: 36832
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FE1 RID: 36833
			private static readonly System.IntPtr NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0;
		}
	}
}
