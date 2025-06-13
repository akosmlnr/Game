using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200044F RID: 1103
	public class DialogueController_ArmsDealer : DialogueController
	{
		// Token: 0x0600600E RID: 24590 RVA: 0x001BC040 File Offset: 0x001BA240
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_ArmsDealer()
		{
			Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_ArmsDealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr);
			DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "MeleeWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "RangedWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "Ammo");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "allWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "chosenWeapon");
			DialogueController_ArmsDealer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675625);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675626);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675627);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675628);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675629);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675630);
			DialogueController_ArmsDealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675631);
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x001BC160 File Offset: 0x001BA360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201017, XrefRangeEnd = 201032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x001BC194 File Offset: 0x001BA394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201032, XrefRangeEnd = 201066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x001BC1E4 File Offset: 0x001BA3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201066, XrefRangeEnd = 201087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			existingChoices = ((intPtr3 == 0) ? null : new List<DialogueChoiceData>(intPtr3));
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x001BC258 File Offset: 0x001BA458
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201124, RefRangeEnd = 201127, XrefRangeStart = 201087, XrefRangeEnd = 201124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueChoiceData> GetWeaponChoices(List<DialogueController_ArmsDealer.WeaponOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr2) : null;
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x001BC2A8 File Offset: 0x001BA4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201127, XrefRangeEnd = 201157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x001BC31C File Offset: 0x001BA51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201157, XrefRangeEnd = 201174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x001BC384 File Offset: 0x001BA584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201174, XrefRangeEnd = 201178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_ArmsDealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x0002D14F File Offset: 0x0002B34F
		public DialogueController_ArmsDealer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06006017 RID: 24599 RVA: 0x001BC3C0 File Offset: 0x001BA5C0
		// (set) Token: 0x06006018 RID: 24600 RVA: 0x0002D158 File Offset: 0x0002B358
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> MeleeWeapons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06006019 RID: 24601 RVA: 0x001BC3F0 File Offset: 0x001BA5F0
		// (set) Token: 0x0600601A RID: 24602 RVA: 0x0002D177 File Offset: 0x0002B377
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> RangedWeapons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x0600601B RID: 24603 RVA: 0x001BC420 File Offset: 0x001BA620
		// (set) Token: 0x0600601C RID: 24604 RVA: 0x0002D196 File Offset: 0x0002B396
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> Ammo
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x0600601D RID: 24605 RVA: 0x001BC450 File Offset: 0x001BA650
		// (set) Token: 0x0600601E RID: 24606 RVA: 0x0002D1B5 File Offset: 0x0002B3B5
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> allWeapons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x0600601F RID: 24607 RVA: 0x001BC480 File Offset: 0x001BA680
		// (set) Token: 0x06006020 RID: 24608 RVA: 0x0002D1D4 File Offset: 0x0002B3D4
		public unsafe DialogueController_ArmsDealer.WeaponOption chosenWeapon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_ArmsDealer.WeaponOption>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041B7 RID: 16823
		private static readonly System.IntPtr NativeFieldInfoPtr_MeleeWeapons;

		// Token: 0x040041B8 RID: 16824
		private static readonly System.IntPtr NativeFieldInfoPtr_RangedWeapons;

		// Token: 0x040041B9 RID: 16825
		private static readonly System.IntPtr NativeFieldInfoPtr_Ammo;

		// Token: 0x040041BA RID: 16826
		private static readonly System.IntPtr NativeFieldInfoPtr_allWeapons;

		// Token: 0x040041BB RID: 16827
		private static readonly System.IntPtr NativeFieldInfoPtr_chosenWeapon;

		// Token: 0x040041BC RID: 16828
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040041BD RID: 16829
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x040041BE RID: 16830
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x040041BF RID: 16831
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0;

		// Token: 0x040041C0 RID: 16832
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x040041C1 RID: 16833
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x040041C2 RID: 16834
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A42 RID: 2626
		[System.Serializable]
		public class WeaponOption : Il2CppSystem.Object
		{
			// Token: 0x0600D31F RID: 54047 RVA: 0x0032EF68 File Offset: 0x0032D168
			// Note: this type is marked as 'beforefieldinit'.
			static WeaponOption()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "WeaponOption");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr);
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Name");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Price");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "IsAvailable");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "NotAvailableReason");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Item");
				DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, 100675632);
			}

			// Token: 0x0600D320 RID: 54048 RVA: 0x0032F00C File Offset: 0x0032D20C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeaponOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D321 RID: 54049 RVA: 0x000665E4 File Offset: 0x000647E4
			public WeaponOption(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004168 RID: 16744
			// (get) Token: 0x0600D322 RID: 54050 RVA: 0x0032F048 File Offset: 0x0032D248
			// (set) Token: 0x0600D323 RID: 54051 RVA: 0x000665ED File Offset: 0x000647ED
			public unsafe string Name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004169 RID: 16745
			// (get) Token: 0x0600D324 RID: 54052 RVA: 0x0032F070 File Offset: 0x0032D270
			// (set) Token: 0x0600D325 RID: 54053 RVA: 0x0006660C File Offset: 0x0006480C
			public unsafe float Price
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x1700416A RID: 16746
			// (get) Token: 0x0600D326 RID: 54054 RVA: 0x0032F098 File Offset: 0x0032D298
			// (set) Token: 0x0600D327 RID: 54055 RVA: 0x00066627 File Offset: 0x00064827
			public unsafe bool IsAvailable
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable)) = value;
				}
			}

			// Token: 0x1700416B RID: 16747
			// (get) Token: 0x0600D328 RID: 54056 RVA: 0x0032F0C0 File Offset: 0x0032D2C0
			// (set) Token: 0x0600D329 RID: 54057 RVA: 0x00066642 File Offset: 0x00064842
			public unsafe string NotAvailableReason
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700416C RID: 16748
			// (get) Token: 0x0600D32A RID: 54058 RVA: 0x0032F0E8 File Offset: 0x0032D2E8
			// (set) Token: 0x0600D32B RID: 54059 RVA: 0x00066661 File Offset: 0x00064861
			public unsafe StorableItemDefinition Item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EA2 RID: 36514
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008EA3 RID: 36515
			private static readonly System.IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04008EA4 RID: 36516
			private static readonly System.IntPtr NativeFieldInfoPtr_IsAvailable;

			// Token: 0x04008EA5 RID: 36517
			private static readonly System.IntPtr NativeFieldInfoPtr_NotAvailableReason;

			// Token: 0x04008EA6 RID: 36518
			private static readonly System.IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008EA7 RID: 36519
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A43 RID: 2627
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D32C RID: 54060 RVA: 0x0032F118 File Offset: 0x0032D318
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr);
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, "choiceLabel");
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, 100675633);
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, 100675634);
			}

			// Token: 0x0600D32D RID: 54061 RVA: 0x0032F180 File Offset: 0x0032D380
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D32E RID: 54062 RVA: 0x0032F1BC File Offset: 0x0032D3BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(DialogueController_ArmsDealer.WeaponOption x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D32F RID: 54063 RVA: 0x00066680 File Offset: 0x00064880
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700416D RID: 16749
			// (get) Token: 0x0600D330 RID: 54064 RVA: 0x0032F20C File Offset: 0x0032D40C
			// (set) Token: 0x0600D331 RID: 54065 RVA: 0x00066689 File Offset: 0x00064889
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EA8 RID: 36520
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008EA9 RID: 36521
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EAA RID: 36522
			private static readonly System.IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0;
		}

		// Token: 0x02000A44 RID: 2628
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D332 RID: 54066 RVA: 0x0032F234 File Offset: 0x0032D434
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr);
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, "choiceLabel");
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, 100675635);
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, 100675636);
			}

			// Token: 0x0600D333 RID: 54067 RVA: 0x0032F29C File Offset: 0x0032D49C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D334 RID: 54068 RVA: 0x0032F2D8 File Offset: 0x0032D4D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(DialogueController_ArmsDealer.WeaponOption x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D335 RID: 54069 RVA: 0x000666A8 File Offset: 0x000648A8
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700416E RID: 16750
			// (get) Token: 0x0600D336 RID: 54070 RVA: 0x0032F328 File Offset: 0x0032D528
			// (set) Token: 0x0600D337 RID: 54071 RVA: 0x000666B1 File Offset: 0x000648B1
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EAB RID: 36523
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008EAC RID: 36524
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EAD RID: 36525
			private static readonly System.IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0;
		}
	}
}
