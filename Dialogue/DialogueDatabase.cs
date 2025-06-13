using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200045A RID: 1114
	[System.Serializable]
	public class DialogueDatabase : ScriptableObject
	{
		// Token: 0x06006094 RID: 24724 RVA: 0x001BE0B8 File Offset: 0x001BC2B8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueDatabase()
		{
			Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr);
			DialogueDatabase.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "Modules");
			DialogueDatabase.NativeFieldInfoPtr_GenericEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "GenericEntries");
			DialogueDatabase.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "handler");
			DialogueDatabase.NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675698);
			DialogueDatabase.NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675699);
			DialogueDatabase.NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675700);
			DialogueDatabase.NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675701);
			DialogueDatabase.NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675702);
			DialogueDatabase.NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675703);
			DialogueDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675704);
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06006095 RID: 24725 RVA: 0x001BE1B0 File Offset: 0x001BC3B0
		public unsafe List<DialogueModule> runtimeModules
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x001BE1F0 File Offset: 0x001BC3F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DialogueHandler _handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_handler);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x001BE234 File Offset: 0x001BC434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202018, RefRangeEnd = 202021, XrefRangeStart = 201969, XrefRangeEnd = 202018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule GetModule(EDialogueModule moduleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref moduleType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueModule>(intPtr2) : null;
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x001BE280 File Offset: 0x001BC480
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 202038, RefRangeEnd = 202053, XrefRangeStart = 202021, XrefRangeEnd = 202038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetChain(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr2) : null;
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x001BE2E0 File Offset: 0x001BC4E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202062, RefRangeEnd = 202063, XrefRangeStart = 202053, XrefRangeEnd = 202062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChain(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x001BE33C File Offset: 0x001BC53C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 202077, RefRangeEnd = 202112, XrefRangeStart = 202063, XrefRangeEnd = 202077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLine(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x001BE394 File Offset: 0x001BC594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202112, XrefRangeEnd = 202120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x0002D4CC File Offset: 0x0002B6CC
		public DialogueDatabase(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x0600609D RID: 24733 RVA: 0x001BE3D0 File Offset: 0x001BC5D0
		// (set) Token: 0x0600609E RID: 24734 RVA: 0x0002D4D5 File Offset: 0x0002B6D5
		public unsafe List<DialogueModule> Modules
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_Modules);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x0600609F RID: 24735 RVA: 0x001BE400 File Offset: 0x001BC600
		// (set) Token: 0x060060A0 RID: 24736 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		public unsafe List<Entry> GenericEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_GenericEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_GenericEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x060060A1 RID: 24737 RVA: 0x001BE430 File Offset: 0x001BC630
		// (set) Token: 0x060060A2 RID: 24738 RVA: 0x0002D513 File Offset: 0x0002B713
		public unsafe DialogueHandler handler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_handler);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400420D RID: 16909
		private static readonly System.IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x0400420E RID: 16910
		private static readonly System.IntPtr NativeFieldInfoPtr_GenericEntries;

		// Token: 0x0400420F RID: 16911
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x04004210 RID: 16912
		private static readonly System.IntPtr NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0;

		// Token: 0x04004211 RID: 16913
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0;

		// Token: 0x04004212 RID: 16914
		private static readonly System.IntPtr NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0;

		// Token: 0x04004213 RID: 16915
		private static readonly System.IntPtr NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0;

		// Token: 0x04004214 RID: 16916
		private static readonly System.IntPtr NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0;

		// Token: 0x04004215 RID: 16917
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0;

		// Token: 0x04004216 RID: 16918
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A49 RID: 2633
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueDatabase+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D359 RID: 54105 RVA: 0x0032F890 File Offset: 0x0032DA90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr);
				DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, "moduleType");
				DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, 100675705);
				DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, 100675706);
			}

			// Token: 0x0600D35A RID: 54106 RVA: 0x0032F8F8 File Offset: 0x0032DAF8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D35B RID: 54107 RVA: 0x0032F934 File Offset: 0x0032DB34
			[CallerCount(0)]
			public unsafe bool _GetModule_b__0(DialogueModule module)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D35C RID: 54108 RVA: 0x000667E9 File Offset: 0x000649E9
			public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004178 RID: 16760
			// (get) Token: 0x0600D35D RID: 54109 RVA: 0x0032F984 File Offset: 0x0032DB84
			// (set) Token: 0x0600D35E RID: 54110 RVA: 0x000667F2 File Offset: 0x000649F2
			public unsafe EDialogueModule moduleType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType)) = value;
				}
			}

			// Token: 0x04008EBE RID: 36542
			private static readonly System.IntPtr NativeFieldInfoPtr_moduleType;

			// Token: 0x04008EBF RID: 36543
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EC0 RID: 36544
			private static readonly System.IntPtr NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0;
		}
	}
}
