using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000456 RID: 1110
	public class DialogueController_SkateboardSeller : DialogueController
	{
		// Token: 0x06006071 RID: 24689 RVA: 0x001BD8E8 File Offset: 0x001BBAE8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_SkateboardSeller()
		{
			Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_SkateboardSeller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr);
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "Options");
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "chosenWeapon");
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "onPurchase");
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675678);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675679);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675680);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675681);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675682);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675683);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675684);
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x001BD9E0 File Offset: 0x001BBBE0
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x001BDA14 File Offset: 0x001BBC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201785, XrefRangeEnd = 201831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x001BDA64 File Offset: 0x001BBC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201831, XrefRangeEnd = 201846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			existingChoices = ((intPtr3 == 0) ? null : new List<DialogueChoiceData>(intPtr3));
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x001BDAD8 File Offset: 0x001BBCD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201883, RefRangeEnd = 201884, XrefRangeStart = 201846, XrefRangeEnd = 201883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueChoiceData> GetChoices(List<DialogueController_SkateboardSeller.Option> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr2) : null;
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x001BDB28 File Offset: 0x001BBD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201884, XrefRangeEnd = 201909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x001BDB9C File Offset: 0x001BBD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201909, XrefRangeEnd = 201926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x001BDC04 File Offset: 0x001BBE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201926, XrefRangeEnd = 201937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_SkateboardSeller() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x0002D3EE File Offset: 0x0002B5EE
		public DialogueController_SkateboardSeller(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x0600607A RID: 24698 RVA: 0x001BDC40 File Offset: 0x001BBE40
		// (set) Token: 0x0600607B RID: 24699 RVA: 0x0002D3F7 File Offset: 0x0002B5F7
		public unsafe List<DialogueController_SkateboardSeller.Option> Options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_SkateboardSeller.Option>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x001BDC70 File Offset: 0x001BBE70
		// (set) Token: 0x0600607D RID: 24701 RVA: 0x0002D416 File Offset: 0x0002B616
		public unsafe DialogueController_SkateboardSeller.Option chosenWeapon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_SkateboardSeller.Option>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x0600607E RID: 24702 RVA: 0x001BDCA0 File Offset: 0x001BBEA0
		// (set) Token: 0x0600607F RID: 24703 RVA: 0x0002D435 File Offset: 0x0002B635
		public unsafe UnityEvent onPurchase
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041F8 RID: 16888
		private static readonly System.IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040041F9 RID: 16889
		private static readonly System.IntPtr NativeFieldInfoPtr_chosenWeapon;

		// Token: 0x040041FA RID: 16890
		private static readonly System.IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x040041FB RID: 16891
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040041FC RID: 16892
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x040041FD RID: 16893
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x040041FE RID: 16894
		private static readonly System.IntPtr NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0;

		// Token: 0x040041FF RID: 16895
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04004200 RID: 16896
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04004201 RID: 16897
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A46 RID: 2630
		[System.Serializable]
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600D340 RID: 54080 RVA: 0x0032F4A8 File Offset: 0x0032D6A8
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr);
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Name");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Price");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "IsAvailable");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "NotAvailableReason");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Item");
				DialogueController_SkateboardSeller.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, 100675685);
			}

			// Token: 0x0600D341 RID: 54081 RVA: 0x0032F54C File Offset: 0x0032D74C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D342 RID: 54082 RVA: 0x000666FD File Offset: 0x000648FD
			public Option(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004171 RID: 16753
			// (get) Token: 0x0600D343 RID: 54083 RVA: 0x0032F588 File Offset: 0x0032D788
			// (set) Token: 0x0600D344 RID: 54084 RVA: 0x00066706 File Offset: 0x00064906
			public unsafe string Name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004172 RID: 16754
			// (get) Token: 0x0600D345 RID: 54085 RVA: 0x0032F5B0 File Offset: 0x0032D7B0
			// (set) Token: 0x0600D346 RID: 54086 RVA: 0x00066725 File Offset: 0x00064925
			public unsafe float Price
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x17004173 RID: 16755
			// (get) Token: 0x0600D347 RID: 54087 RVA: 0x0032F5D8 File Offset: 0x0032D7D8
			// (set) Token: 0x0600D348 RID: 54088 RVA: 0x00066740 File Offset: 0x00064940
			public unsafe bool IsAvailable
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable)) = value;
				}
			}

			// Token: 0x17004174 RID: 16756
			// (get) Token: 0x0600D349 RID: 54089 RVA: 0x0032F600 File Offset: 0x0032D800
			// (set) Token: 0x0600D34A RID: 54090 RVA: 0x0006675B File Offset: 0x0006495B
			public unsafe string NotAvailableReason
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004175 RID: 16757
			// (get) Token: 0x0600D34B RID: 54091 RVA: 0x0032F628 File Offset: 0x0032D828
			// (set) Token: 0x0600D34C RID: 54092 RVA: 0x0006677A File Offset: 0x0006497A
			public unsafe ItemDefinition Item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EB2 RID: 36530
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008EB3 RID: 36531
			private static readonly System.IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04008EB4 RID: 36532
			private static readonly System.IntPtr NativeFieldInfoPtr_IsAvailable;

			// Token: 0x04008EB5 RID: 36533
			private static readonly System.IntPtr NativeFieldInfoPtr_NotAvailableReason;

			// Token: 0x04008EB6 RID: 36534
			private static readonly System.IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008EB7 RID: 36535
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A47 RID: 2631
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_SkateboardSeller+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D34D RID: 54093 RVA: 0x0032F658 File Offset: 0x0032D858
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr);
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, "choiceLabel");
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, 100675686);
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, 100675687);
			}

			// Token: 0x0600D34E RID: 54094 RVA: 0x0032F6C0 File Offset: 0x0032D8C0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D34F RID: 54095 RVA: 0x0032F6FC File Offset: 0x0032D8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(DialogueController_SkateboardSeller.Option x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D350 RID: 54096 RVA: 0x00066799 File Offset: 0x00064999
			public __c__DisplayClass5_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004176 RID: 16758
			// (get) Token: 0x0600D351 RID: 54097 RVA: 0x0032F74C File Offset: 0x0032D94C
			// (set) Token: 0x0600D352 RID: 54098 RVA: 0x000667A2 File Offset: 0x000649A2
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EB8 RID: 36536
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008EB9 RID: 36537
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EBA RID: 36538
			private static readonly System.IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0;
		}

		// Token: 0x02000A48 RID: 2632
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_SkateboardSeller+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D353 RID: 54099 RVA: 0x0032F774 File Offset: 0x0032D974
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr);
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, "choiceLabel");
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, 100675688);
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, 100675689);
			}

			// Token: 0x0600D354 RID: 54100 RVA: 0x0032F7DC File Offset: 0x0032D9DC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D355 RID: 54101 RVA: 0x0032F818 File Offset: 0x0032DA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(DialogueController_SkateboardSeller.Option x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D356 RID: 54102 RVA: 0x000667C1 File Offset: 0x000649C1
			public __c__DisplayClass8_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004177 RID: 16759
			// (get) Token: 0x0600D357 RID: 54103 RVA: 0x0032F868 File Offset: 0x0032DA68
			// (set) Token: 0x0600D358 RID: 54104 RVA: 0x000667CA File Offset: 0x000649CA
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EBB RID: 36539
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008EBC RID: 36540
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EBD RID: 36541
			private static readonly System.IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0;
		}
	}
}
