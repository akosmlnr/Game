using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000460 RID: 1120
	public class DialogueHandler_EstateAgent : ControlledDialogueHandler
	{
		// Token: 0x06006116 RID: 24854 RVA: 0x001BFD48 File Offset: 0x001BDF48
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_EstateAgent()
		{
			Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_EstateAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr);
			DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "selectedProperty");
			DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedBusiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "selectedBusiness");
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675766);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675767);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675768);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675769);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675770);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675771);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675772);
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x001BFE2C File Offset: 0x001BE02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202582, XrefRangeEnd = 202625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x001BFEA0 File Offset: 0x001BE0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202625, XrefRangeEnd = 202663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldChoiceBeShown(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x001BFEF8 File Offset: 0x001BE0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202663, XrefRangeEnd = 202705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x001BFF48 File Offset: 0x001BE148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202705, XrefRangeEnd = 202732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DialogueCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x001BFF98 File Offset: 0x001BE198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202732, XrefRangeEnd = 202747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x001C0000 File Offset: 0x001BE200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202747, XrefRangeEnd = 202799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x001C0068 File Offset: 0x001BE268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_EstateAgent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600611E RID: 24862 RVA: 0x0002D8D4 File Offset: 0x0002BAD4
		public DialogueHandler_EstateAgent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x0600611F RID: 24863 RVA: 0x001C00A4 File Offset: 0x001BE2A4
		// (set) Token: 0x06006120 RID: 24864 RVA: 0x0002D8DD File Offset: 0x0002BADD
		public unsafe Property selectedProperty
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedProperty);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06006121 RID: 24865 RVA: 0x001C00D4 File Offset: 0x001BE2D4
		// (set) Token: 0x06006122 RID: 24866 RVA: 0x0002D8FC File Offset: 0x0002BAFC
		public unsafe Business selectedBusiness
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedBusiness);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedBusiness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004262 RID: 16994
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x04004263 RID: 16995
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedBusiness;

		// Token: 0x04004264 RID: 16996
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04004265 RID: 16997
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_Boolean_String_0;

		// Token: 0x04004266 RID: 16998
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0;

		// Token: 0x04004267 RID: 16999
		private static readonly System.IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0;

		// Token: 0x04004268 RID: 17000
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0;

		// Token: 0x04004269 RID: 17001
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0;

		// Token: 0x0400426A RID: 17002
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A4D RID: 2637
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_EstateAgent+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D378 RID: 54136 RVA: 0x0032FE04 File Offset: 0x0032E004
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr, 100675773);
				DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr, 100675774);
				DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__CheckChoice_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr, 100675775);
			}

			// Token: 0x0600D379 RID: 54137 RVA: 0x0032FE80 File Offset: 0x0032E080
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D37A RID: 54138 RVA: 0x0032FEBC File Offset: 0x0032E0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202578, XrefRangeEnd = 202582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D37B RID: 54139 RVA: 0x0032FF0C File Offset: 0x0032E10C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__1(Business x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__CheckChoice_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D37C RID: 54140 RVA: 0x000668E2 File Offset: 0x00064AE2
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700417F RID: 16767
			// (get) Token: 0x0600D37D RID: 54141 RVA: 0x0032FF5C File Offset: 0x0032E15C
			// (set) Token: 0x0600D37E RID: 54142 RVA: 0x000668EB File Offset: 0x00064AEB
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008ECE RID: 36558
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008ECF RID: 36559
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ED0 RID: 36560
			private static readonly System.IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008ED1 RID: 36561
			private static readonly System.IntPtr NativeMethodInfoPtr__CheckChoice_b__1_Internal_Boolean_Business_0;
		}

		// Token: 0x02000A4E RID: 2638
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_EstateAgent+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D37F RID: 54143 RVA: 0x0032FF84 File Offset: 0x0032E184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr);
				DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr, 100675776);
				DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ShouldChoiceBeShown_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr, 100675777);
				DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ShouldChoiceBeShown_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr, 100675778);
			}

			// Token: 0x0600D380 RID: 54144 RVA: 0x00330000 File Offset: 0x0032E200
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D381 RID: 54145 RVA: 0x0033003C File Offset: 0x0032E23C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShouldChoiceBeShown_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ShouldChoiceBeShown_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D382 RID: 54146 RVA: 0x0033008C File Offset: 0x0032E28C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShouldChoiceBeShown_b__1(Business x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ShouldChoiceBeShown_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D383 RID: 54147 RVA: 0x0006690A File Offset: 0x00064B0A
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004180 RID: 16768
			// (get) Token: 0x0600D384 RID: 54148 RVA: 0x003300DC File Offset: 0x0032E2DC
			// (set) Token: 0x0600D385 RID: 54149 RVA: 0x00066913 File Offset: 0x00064B13
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008ED2 RID: 36562
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008ED3 RID: 36563
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ED4 RID: 36564
			private static readonly System.IntPtr NativeMethodInfoPtr__ShouldChoiceBeShown_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008ED5 RID: 36565
			private static readonly System.IntPtr NativeMethodInfoPtr__ShouldChoiceBeShown_b__1_Internal_Boolean_Business_0;
		}

		// Token: 0x02000A4F RID: 2639
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_EstateAgent+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D386 RID: 54150 RVA: 0x00330104 File Offset: 0x0032E304
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr);
				DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr, 100675779);
				DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr, 100675780);
				DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr, 100675781);
			}

			// Token: 0x0600D387 RID: 54151 RVA: 0x00330180 File Offset: 0x0032E380
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D388 RID: 54152 RVA: 0x003301BC File Offset: 0x0032E3BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D389 RID: 54153 RVA: 0x0033020C File Offset: 0x0032E40C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__1(Business x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D38A RID: 54154 RVA: 0x00066932 File Offset: 0x00064B32
			public __c__DisplayClass4_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004181 RID: 16769
			// (get) Token: 0x0600D38B RID: 54155 RVA: 0x0033025C File Offset: 0x0032E45C
			// (set) Token: 0x0600D38C RID: 54156 RVA: 0x0006693B File Offset: 0x00064B3B
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008ED6 RID: 36566
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008ED7 RID: 36567
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ED8 RID: 36568
			private static readonly System.IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008ED9 RID: 36569
			private static readonly System.IntPtr NativeMethodInfoPtr__ChoiceCallback_b__1_Internal_Boolean_Business_0;
		}

		// Token: 0x02000A50 RID: 2640
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_EstateAgent+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D38D RID: 54157 RVA: 0x00330284 File Offset: 0x0032E484
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr);
				DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr, 100675782);
				DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr, 100675783);
				DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ModifyChoiceText_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr, 100675784);
			}

			// Token: 0x0600D38E RID: 54158 RVA: 0x00330300 File Offset: 0x0032E500
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D38F RID: 54159 RVA: 0x0033033C File Offset: 0x0032E53C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ModifyChoiceText_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D390 RID: 54160 RVA: 0x0033038C File Offset: 0x0032E58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ModifyChoiceText_b__1(Business x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ModifyChoiceText_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D391 RID: 54161 RVA: 0x0006695A File Offset: 0x00064B5A
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004182 RID: 16770
			// (get) Token: 0x0600D392 RID: 54162 RVA: 0x003303DC File Offset: 0x0032E5DC
			// (set) Token: 0x0600D393 RID: 54163 RVA: 0x00066963 File Offset: 0x00064B63
			public unsafe string choiceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EDA RID: 36570
			private static readonly System.IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008EDB RID: 36571
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EDC RID: 36572
			private static readonly System.IntPtr NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008EDD RID: 36573
			private static readonly System.IntPtr NativeMethodInfoPtr__ModifyChoiceText_b__1_Internal_Boolean_Business_0;
		}
	}
}
