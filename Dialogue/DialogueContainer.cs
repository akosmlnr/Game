using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000469 RID: 1129
	[System.Serializable]
	public class DialogueContainer : ScriptableObject
	{
		// Token: 0x06006168 RID: 24936 RVA: 0x001C0EC4 File Offset: 0x001BF0C4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueContainer()
		{
			Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr);
			DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<allowExit>k__BackingField");
			DialogueContainer.NativeFieldInfoPtr_NodeLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "NodeLinks");
			DialogueContainer.NativeFieldInfoPtr_DialogueNodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "DialogueNodeData");
			DialogueContainer.NativeFieldInfoPtr_BranchNodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "BranchNodeData");
			DialogueContainer.NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675816);
			DialogueContainer.NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675817);
			DialogueContainer.NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675818);
			DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675819);
			DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675820);
			DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675821);
			DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675822);
			DialogueContainer.NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675823);
			DialogueContainer.NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675824);
			DialogueContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675825);
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06006169 RID: 24937 RVA: 0x001C100C File Offset: 0x001BF20C
		// (set) Token: 0x0600616A RID: 24938 RVA: 0x001C1048 File Offset: 0x001BF248
		public unsafe bool allowExit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x0600616B RID: 24939 RVA: 0x001C1088 File Offset: 0x001BF288
		public unsafe bool AllowExit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 203060, RefRangeEnd = 203061, XrefRangeStart = 203054, XrefRangeEnd = 203060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x001C10C4 File Offset: 0x001BF2C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 203076, RefRangeEnd = 203085, XrefRangeStart = 203061, XrefRangeEnd = 203076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueNodeLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x001C1114 File Offset: 0x001BF314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 203100, RefRangeEnd = 203102, XrefRangeStart = 203085, XrefRangeEnd = 203100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BranchNodeData>(intPtr2) : null;
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x001C1164 File Offset: 0x001BF364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 203117, RefRangeEnd = 203119, XrefRangeStart = 203102, XrefRangeEnd = 203117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueNodeGUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x001C11B4 File Offset: 0x001BF3B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 203134, RefRangeEnd = 203136, XrefRangeStart = 203119, XrefRangeEnd = 203134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchGUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BranchNodeData>(intPtr2) : null;
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x001C1204 File Offset: 0x001BF404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203136, XrefRangeEnd = 203151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseChoiceOrOptionGUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NodeLinkData>(intPtr2) : null;
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x001C1254 File Offset: 0x001BF454
		[CallerCount(0)]
		public unsafe void SetAllowExit(bool allowed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref allowed;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x001C1294 File Offset: 0x001BF494
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203173, RefRangeEnd = 203176, XrefRangeStart = 203151, XrefRangeEnd = 203173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x0002DB42 File Offset: 0x0002BD42
		public DialogueContainer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06006174 RID: 24948 RVA: 0x001C12D0 File Offset: 0x001BF4D0
		// (set) Token: 0x06006175 RID: 24949 RVA: 0x0002DB4B File Offset: 0x0002BD4B
		public unsafe bool _allowExit_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06006176 RID: 24950 RVA: 0x001C12F8 File Offset: 0x001BF4F8
		// (set) Token: 0x06006177 RID: 24951 RVA: 0x0002DB66 File Offset: 0x0002BD66
		public unsafe List<NodeLinkData> NodeLinks
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_NodeLinks);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLinkData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_NodeLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x001C1328 File Offset: 0x001BF528
		// (set) Token: 0x06006179 RID: 24953 RVA: 0x0002DB85 File Offset: 0x0002BD85
		public unsafe List<DialogueNodeData> DialogueNodeData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_DialogueNodeData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueNodeData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_DialogueNodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x0600617A RID: 24954 RVA: 0x001C1358 File Offset: 0x001BF558
		// (set) Token: 0x0600617B RID: 24955 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
		public unsafe List<BranchNodeData> BranchNodeData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_BranchNodeData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BranchNodeData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_BranchNodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400429A RID: 17050
		private static readonly System.IntPtr NativeFieldInfoPtr__allowExit_k__BackingField;

		// Token: 0x0400429B RID: 17051
		private static readonly System.IntPtr NativeFieldInfoPtr_NodeLinks;

		// Token: 0x0400429C RID: 17052
		private static readonly System.IntPtr NativeFieldInfoPtr_DialogueNodeData;

		// Token: 0x0400429D RID: 17053
		private static readonly System.IntPtr NativeFieldInfoPtr_BranchNodeData;

		// Token: 0x0400429E RID: 17054
		private static readonly System.IntPtr NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0;

		// Token: 0x0400429F RID: 17055
		private static readonly System.IntPtr NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0;

		// Token: 0x040042A0 RID: 17056
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0;

		// Token: 0x040042A1 RID: 17057
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0;

		// Token: 0x040042A2 RID: 17058
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0;

		// Token: 0x040042A3 RID: 17059
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0;

		// Token: 0x040042A4 RID: 17060
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0;

		// Token: 0x040042A5 RID: 17061
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0;

		// Token: 0x040042A6 RID: 17062
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0;

		// Token: 0x040042A7 RID: 17063
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A55 RID: 2645
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3AC RID: 54188 RVA: 0x00330878 File Offset: 0x0032EA78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, "branchLabel");
				DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, 100675826);
				DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, 100675827);
			}

			// Token: 0x0600D3AD RID: 54189 RVA: 0x003308E0 File Offset: 0x0032EAE0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3AE RID: 54190 RVA: 0x0033091C File Offset: 0x0032EB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBranchNodeByLabel_b__0(BranchNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D3AF RID: 54191 RVA: 0x00066A1E File Offset: 0x00064C1E
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004187 RID: 16775
			// (get) Token: 0x0600D3B0 RID: 54192 RVA: 0x0033096C File Offset: 0x0032EB6C
			// (set) Token: 0x0600D3B1 RID: 54193 RVA: 0x00066A27 File Offset: 0x00064C27
			public unsafe string branchLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EEA RID: 36586
			private static readonly System.IntPtr NativeFieldInfoPtr_branchLabel;

			// Token: 0x04008EEB RID: 36587
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EEC RID: 36588
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0;
		}

		// Token: 0x02000A56 RID: 2646
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3B2 RID: 54194 RVA: 0x00330994 File Offset: 0x0032EB94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, "dialogueNodeGUID");
				DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, 100675828);
				DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, 100675829);
			}

			// Token: 0x0600D3B3 RID: 54195 RVA: 0x003309FC File Offset: 0x0032EBFC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3B4 RID: 54196 RVA: 0x00330A38 File Offset: 0x0032EC38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDialogueNodeByGUID_b__0(DialogueNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D3B5 RID: 54197 RVA: 0x00066A46 File Offset: 0x00064C46
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004188 RID: 16776
			// (get) Token: 0x0600D3B6 RID: 54198 RVA: 0x00330A88 File Offset: 0x0032EC88
			// (set) Token: 0x0600D3B7 RID: 54199 RVA: 0x00066A4F File Offset: 0x00064C4F
			public unsafe string dialogueNodeGUID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EED RID: 36589
			private static readonly System.IntPtr NativeFieldInfoPtr_dialogueNodeGUID;

			// Token: 0x04008EEE RID: 36590
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EEF RID: 36591
			private static readonly System.IntPtr NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0;
		}

		// Token: 0x02000A57 RID: 2647
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3B8 RID: 54200 RVA: 0x00330AB0 File Offset: 0x0032ECB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, "branchGUID");
				DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, 100675830);
				DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, 100675831);
			}

			// Token: 0x0600D3B9 RID: 54201 RVA: 0x00330B18 File Offset: 0x0032ED18
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3BA RID: 54202 RVA: 0x00330B54 File Offset: 0x0032ED54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBranchNodeByGUID_b__0(BranchNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D3BB RID: 54203 RVA: 0x00066A6E File Offset: 0x00064C6E
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004189 RID: 16777
			// (get) Token: 0x0600D3BC RID: 54204 RVA: 0x00330BA4 File Offset: 0x0032EDA4
			// (set) Token: 0x0600D3BD RID: 54205 RVA: 0x00066A77 File Offset: 0x00064C77
			public unsafe string branchGUID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EF0 RID: 36592
			private static readonly System.IntPtr NativeFieldInfoPtr_branchGUID;

			// Token: 0x04008EF1 RID: 36593
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EF2 RID: 36594
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0;
		}

		// Token: 0x02000A58 RID: 2648
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3BE RID: 54206 RVA: 0x00330BCC File Offset: 0x0032EDCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, "baseChoiceOrOptionGUID");
				DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, 100675832);
				DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, 100675833);
			}

			// Token: 0x0600D3BF RID: 54207 RVA: 0x00330C34 File Offset: 0x0032EE34
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3C0 RID: 54208 RVA: 0x00330C70 File Offset: 0x0032EE70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLink_b__0(NodeLinkData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D3C1 RID: 54209 RVA: 0x00066A96 File Offset: 0x00064C96
			public __c__DisplayClass13_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700418A RID: 16778
			// (get) Token: 0x0600D3C2 RID: 54210 RVA: 0x00330CC0 File Offset: 0x0032EEC0
			// (set) Token: 0x0600D3C3 RID: 54211 RVA: 0x00066A9F File Offset: 0x00064C9F
			public unsafe string baseChoiceOrOptionGUID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EF3 RID: 36595
			private static readonly System.IntPtr NativeFieldInfoPtr_baseChoiceOrOptionGUID;

			// Token: 0x04008EF4 RID: 36596
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EF5 RID: 36597
			private static readonly System.IntPtr NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0;
		}

		// Token: 0x02000A59 RID: 2649
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3C4 RID: 54212 RVA: 0x00330CE8 File Offset: 0x0032EEE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, "dialogueNodeLabel");
				DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, 100675834);
				DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, 100675835);
			}

			// Token: 0x0600D3C5 RID: 54213 RVA: 0x00330D50 File Offset: 0x0032EF50
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3C6 RID: 54214 RVA: 0x00330D8C File Offset: 0x0032EF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203038, XrefRangeEnd = 203054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDialogueNodeByLabel_b__0(DialogueNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D3C7 RID: 54215 RVA: 0x00066ABE File Offset: 0x00064CBE
			public __c__DisplayClass9_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700418B RID: 16779
			// (get) Token: 0x0600D3C8 RID: 54216 RVA: 0x00330DDC File Offset: 0x0032EFDC
			// (set) Token: 0x0600D3C9 RID: 54217 RVA: 0x00066AC7 File Offset: 0x00064CC7
			public unsafe string dialogueNodeLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EF6 RID: 36598
			private static readonly System.IntPtr NativeFieldInfoPtr_dialogueNodeLabel;

			// Token: 0x04008EF7 RID: 36599
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EF8 RID: 36600
			private static readonly System.IntPtr NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0;
		}
	}
}
