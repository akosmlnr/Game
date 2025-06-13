using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000463 RID: 1123
	public class DialogueManager : Singleton<DialogueManager>
	{
		// Token: 0x0600613C RID: 24892 RVA: 0x001C0774 File Offset: 0x001BE974
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueManager()
		{
			Il2CppClassPointerStore<DialogueManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr);
			DialogueManager.NativeFieldInfoPtr_DefaultDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "DefaultDatabase");
			DialogueManager.NativeFieldInfoPtr_DefaultModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "DefaultModules");
			DialogueManager.NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, 100675802);
			DialogueManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, 100675803);
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x001C07F4 File Offset: 0x001BE9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202957, XrefRangeEnd = 202984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule Get(EDialogueModule moduleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref moduleType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueModule>(intPtr2) : null;
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x001C0840 File Offset: 0x001BEA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202984, XrefRangeEnd = 202994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x0002D9A9 File Offset: 0x0002BBA9
		public DialogueManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06006140 RID: 24896 RVA: 0x001C087C File Offset: 0x001BEA7C
		// (set) Token: 0x06006141 RID: 24897 RVA: 0x0002D9B2 File Offset: 0x0002BBB2
		public unsafe DialogueDatabase DefaultDatabase
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultDatabase);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06006142 RID: 24898 RVA: 0x001C08AC File Offset: 0x001BEAAC
		// (set) Token: 0x06006143 RID: 24899 RVA: 0x0002D9D1 File Offset: 0x0002BBD1
		public unsafe List<DialogueModule> DefaultModules
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultModules);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400427C RID: 17020
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultDatabase;

		// Token: 0x0400427D RID: 17021
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultModules;

		// Token: 0x0400427E RID: 17022
		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0;

		// Token: 0x0400427F RID: 17023
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A53 RID: 2643
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueManager+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3A0 RID: 54176 RVA: 0x0033063C File Offset: 0x0032E83C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, "moduleType");
				DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, 100675804);
				DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, 100675805);
			}

			// Token: 0x0600D3A1 RID: 54177 RVA: 0x003306A4 File Offset: 0x0032E8A4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3A2 RID: 54178 RVA: 0x003306E0 File Offset: 0x0032E8E0
			[CallerCount(0)]
			public unsafe bool _Get_b__0(DialogueModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D3A3 RID: 54179 RVA: 0x000669D2 File Offset: 0x00064BD2
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004185 RID: 16773
			// (get) Token: 0x0600D3A4 RID: 54180 RVA: 0x00330730 File Offset: 0x0032E930
			// (set) Token: 0x0600D3A5 RID: 54181 RVA: 0x000669DB File Offset: 0x00064BDB
			public unsafe EDialogueModule moduleType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType)) = value;
				}
			}

			// Token: 0x04008EE4 RID: 36580
			private static readonly System.IntPtr NativeFieldInfoPtr_moduleType;

			// Token: 0x04008EE5 RID: 36581
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EE6 RID: 36582
			private static readonly System.IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0;
		}
	}
}
