using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000454 RID: 1108
	public class DialogueController_Ming : DialogueController
	{
		// Token: 0x06006050 RID: 24656 RVA: 0x001BD1FC File Offset: 0x001BB3FC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Ming()
		{
			Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Ming");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr);
			DialogueController_Ming.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "Property");
			DialogueController_Ming.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "Price");
			DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "BuyDialogue");
			DialogueController_Ming.NativeFieldInfoPtr_BuyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "BuyText");
			DialogueController_Ming.NativeFieldInfoPtr_RemindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "RemindText");
			DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "RemindLocationDialogue");
			DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "PurchaseRoomQuests");
			DialogueController_Ming.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "onPurchase");
			DialogueController_Ming.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675664);
			DialogueController_Ming.NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675665);
			DialogueController_Ming.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675666);
			DialogueController_Ming.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675667);
			DialogueController_Ming.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675668);
			DialogueController_Ming.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675669);
			DialogueController_Ming.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675670);
			DialogueController_Ming.NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675671);
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x001BD36C File Offset: 0x001BB56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201664, XrefRangeEnd = 201702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x001BD3A8 File Offset: 0x001BB5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201702, XrefRangeEnd = 201707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBuyRoom(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x001BD3F4 File Offset: 0x001BB5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201707, XrefRangeEnd = 201719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x001BD45C File Offset: 0x001BB65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201719, XrefRangeEnd = 201733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x001BD4C4 File Offset: 0x001BB6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201733, XrefRangeEnd = 201745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x001BD538 File Offset: 0x001BB738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201745, XrefRangeEnd = 201762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x001BD588 File Offset: 0x001BB788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201762, XrefRangeEnd = 201774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Ming() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x001BD5C4 File Offset: 0x001BB7C4
		[CallerCount(0)]
		public unsafe bool _Start_b__8_0(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x0002D2C9 File Offset: 0x0002B4C9
		public DialogueController_Ming(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x001BD610 File Offset: 0x001BB810
		// (set) Token: 0x0600605B RID: 24667 RVA: 0x0002D2D2 File Offset: 0x0002B4D2
		public unsafe Property Property
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Property);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x001BD640 File Offset: 0x001BB840
		// (set) Token: 0x0600605D RID: 24669 RVA: 0x0002D2F1 File Offset: 0x0002B4F1
		public unsafe float Price
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x0600605E RID: 24670 RVA: 0x001BD668 File Offset: 0x001BB868
		// (set) Token: 0x0600605F RID: 24671 RVA: 0x0002D30C File Offset: 0x0002B50C
		public unsafe DialogueContainer BuyDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06006060 RID: 24672 RVA: 0x001BD698 File Offset: 0x001BB898
		// (set) Token: 0x06006061 RID: 24673 RVA: 0x0002D32B File Offset: 0x0002B52B
		public unsafe string BuyText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06006062 RID: 24674 RVA: 0x001BD6C0 File Offset: 0x001BB8C0
		// (set) Token: 0x06006063 RID: 24675 RVA: 0x0002D34A File Offset: 0x0002B54A
		public unsafe string RemindText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06006064 RID: 24676 RVA: 0x001BD6E8 File Offset: 0x001BB8E8
		// (set) Token: 0x06006065 RID: 24677 RVA: 0x0002D369 File Offset: 0x0002B569
		public unsafe DialogueContainer RemindLocationDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x001BD718 File Offset: 0x001BB918
		// (set) Token: 0x06006067 RID: 24679 RVA: 0x0002D388 File Offset: 0x0002B588
		public unsafe Il2CppReferenceArray<QuestEntry> PurchaseRoomQuests
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestEntry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x001BD748 File Offset: 0x001BB948
		// (set) Token: 0x06006069 RID: 24681 RVA: 0x0002D3A7 File Offset: 0x0002B5A7
		public unsafe UnityEvent onPurchase
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_onPurchase);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041E4 RID: 16868
		private static readonly System.IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x040041E5 RID: 16869
		private static readonly System.IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x040041E6 RID: 16870
		private static readonly System.IntPtr NativeFieldInfoPtr_BuyDialogue;

		// Token: 0x040041E7 RID: 16871
		private static readonly System.IntPtr NativeFieldInfoPtr_BuyText;

		// Token: 0x040041E8 RID: 16872
		private static readonly System.IntPtr NativeFieldInfoPtr_RemindText;

		// Token: 0x040041E9 RID: 16873
		private static readonly System.IntPtr NativeFieldInfoPtr_RemindLocationDialogue;

		// Token: 0x040041EA RID: 16874
		private static readonly System.IntPtr NativeFieldInfoPtr_PurchaseRoomQuests;

		// Token: 0x040041EB RID: 16875
		private static readonly System.IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x040041EC RID: 16876
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040041ED RID: 16877
		private static readonly System.IntPtr NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0;

		// Token: 0x040041EE RID: 16878
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0;

		// Token: 0x040041EF RID: 16879
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x040041F0 RID: 16880
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x040041F1 RID: 16881
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x040041F2 RID: 16882
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040041F3 RID: 16883
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0;

		// Token: 0x02000A45 RID: 2629
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_Ming+<>c")]
		[System.Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D338 RID: 54072 RVA: 0x0032F350 File Offset: 0x0032D550
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr);
				DialogueController_Ming.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, "<>9");
				DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, "<>9__9_0");
				DialogueController_Ming.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, 100675673);
				DialogueController_Ming.__c.NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, 100675674);
			}

			// Token: 0x0600D339 RID: 54073 RVA: 0x0032F3CC File Offset: 0x0032D5CC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D33A RID: 54074 RVA: 0x0032F408 File Offset: 0x0032D608
			[CallerCount(0)]
			public unsafe bool _CanBuyRoom_b__9_0(QuestEntry q)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.__c.NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D33B RID: 54075 RVA: 0x000666D0 File Offset: 0x000648D0
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700416F RID: 16751
			// (get) Token: 0x0600D33C RID: 54076 RVA: 0x0032F458 File Offset: 0x0032D658
			// (set) Token: 0x0600D33D RID: 54077 RVA: 0x000666D9 File Offset: 0x000648D9
			public unsafe static DialogueController_Ming.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Ming.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004170 RID: 16752
			// (get) Token: 0x0600D33E RID: 54078 RVA: 0x0032F480 File Offset: 0x0032D680
			// (set) Token: 0x0600D33F RID: 54079 RVA: 0x000666EB File Offset: 0x000648EB
			public unsafe static Il2CppSystem.Func<QuestEntry, bool> __9__9_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<QuestEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EAE RID: 36526
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EAF RID: 36527
			private static readonly System.IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008EB0 RID: 36528
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EB1 RID: 36529
			private static readonly System.IntPtr NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0;
		}
	}
}
