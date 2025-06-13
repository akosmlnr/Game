using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000462 RID: 1122
	public class DialogueHandler_VehicleSalesman : ControlledDialogueHandler
	{
		// Token: 0x0600612F RID: 24879 RVA: 0x001C03B8 File Offset: 0x001BE5B8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_VehicleSalesman()
		{
			Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_VehicleSalesman");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr);
			DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "Salesman");
			DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "selectedVehicle");
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675791);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675792);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675793);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675794);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675795);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675796);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675797);
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x001C049C File Offset: 0x001BE69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202868, XrefRangeEnd = 202900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x001C0504 File Offset: 0x001BE704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202900, XrefRangeEnd = 202915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x001C0578 File Offset: 0x001BE778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202915, XrefRangeEnd = 202940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x001C05C8 File Offset: 0x001BE7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202940, XrefRangeEnd = 202948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x001C0620 File Offset: 0x001BE820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202948, XrefRangeEnd = 202949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DialogueCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x001C0670 File Offset: 0x001BE870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202949, XrefRangeEnd = 202957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x001C06D8 File Offset: 0x001BE8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_VehicleSalesman() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x0002D962 File Offset: 0x0002BB62
		public DialogueHandler_VehicleSalesman(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06006138 RID: 24888 RVA: 0x001C0714 File Offset: 0x001BE914
		// (set) Token: 0x06006139 RID: 24889 RVA: 0x0002D96B File Offset: 0x0002BB6B
		public unsafe Jeremy Salesman
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jeremy>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x0600613A RID: 24890 RVA: 0x001C0744 File Offset: 0x001BE944
		// (set) Token: 0x0600613B RID: 24891 RVA: 0x0002D98A File Offset: 0x0002BB8A
		public unsafe Jeremy.DealershipListing selectedVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jeremy.DealershipListing>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004273 RID: 17011
		private static readonly System.IntPtr NativeFieldInfoPtr_Salesman;

		// Token: 0x04004274 RID: 17012
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedVehicle;

		// Token: 0x04004275 RID: 17013
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0;

		// Token: 0x04004276 RID: 17014
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04004277 RID: 17015
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0;

		// Token: 0x04004278 RID: 17016
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0;

		// Token: 0x04004279 RID: 17017
		private static readonly System.IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0;

		// Token: 0x0400427A RID: 17018
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0;

		// Token: 0x0400427B RID: 17019
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A51 RID: 2641
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_VehicleSalesman+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D394 RID: 54164 RVA: 0x00330404 File Offset: 0x0032E604
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, 100675798);
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, 100675799);
			}

			// Token: 0x0600D395 RID: 54165 RVA: 0x0033046C File Offset: 0x0032E66C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D396 RID: 54166 RVA: 0x003304A8 File Offset: 0x0032E6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ModifyChoiceText_b__0(Jeremy.DealershipListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D397 RID: 54167 RVA: 0x00066982 File Offset: 0x00064B82
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004183 RID: 16771
			// (get) Token: 0x0600D398 RID: 54168 RVA: 0x003304F8 File Offset: 0x0032E6F8
			// (set) Token: 0x0600D399 RID: 54169 RVA: 0x0006698B File Offset: 0x00064B8B
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EDE RID: 36574
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008EDF RID: 36575
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EE0 RID: 36576
			private static readonly System.IntPtr NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0;
		}

		// Token: 0x02000A52 RID: 2642
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_VehicleSalesman+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D39A RID: 54170 RVA: 0x00330520 File Offset: 0x0032E720
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr);
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, 100675800);
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, 100675801);
			}

			// Token: 0x0600D39B RID: 54171 RVA: 0x00330588 File Offset: 0x0032E788
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D39C RID: 54172 RVA: 0x003305C4 File Offset: 0x0032E7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(Jeremy.DealershipListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D39D RID: 54173 RVA: 0x000669AA File Offset: 0x00064BAA
			public __c__DisplayClass4_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004184 RID: 16772
			// (get) Token: 0x0600D39E RID: 54174 RVA: 0x00330614 File Offset: 0x0032E814
			// (set) Token: 0x0600D39F RID: 54175 RVA: 0x000669B3 File Offset: 0x00064BB3
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EE1 RID: 36577
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008EE2 RID: 36578
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EE3 RID: 36579
			private static readonly System.IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0;
		}
	}
}
