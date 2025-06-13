using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000718 RID: 1816
	public class InputPromptsManager : Singleton<InputPromptsManager>
	{
		// Token: 0x0600A198 RID: 41368 RVA: 0x0028EA48 File Offset: 0x0028CC48
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsManager()
		{
			Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr);
			InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "KeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "WideKeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "ExtraWideKeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "LeftClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "MiddleClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "RightClickPromptPrefab");
			InputPromptsManager.NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100683208);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100683209);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100683210);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100683211);
			InputPromptsManager.NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100683212);
			InputPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100683213);
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x0028EB68 File Offset: 0x0028CD68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285477, RefRangeEnd = 285478, XrefRangeStart = 285440, XrefRangeEnd = 285477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImage GetPromptImage(string controlPath, RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptImage>(intPtr2) : null;
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x0028EBCC File Offset: 0x0028CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285478, XrefRangeEnd = 285487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathMouseRelated(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x0028EC1C File Offset: 0x0028CE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285526, RefRangeEnd = 285527, XrefRangeStart = 285487, XrefRangeEnd = 285526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathWideKey(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x0028EC6C File Offset: 0x0028CE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285527, XrefRangeEnd = 285530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathExtraWideKey(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x0028ECBC File Offset: 0x0028CEBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285680, RefRangeEnd = 285685, XrefRangeStart = 285530, XrefRangeEnd = 285680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayNameForControlPath(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x0028ED04 File Offset: 0x0028CF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285685, XrefRangeEnd = 285688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x0004F0DD File Offset: 0x0004D2DD
		public InputPromptsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600A1A0 RID: 41376 RVA: 0x0028ED40 File Offset: 0x0028CF40
		// (set) Token: 0x0600A1A1 RID: 41377 RVA: 0x0004F0E6 File Offset: 0x0004D2E6
		public unsafe GameObject KeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600A1A2 RID: 41378 RVA: 0x0028ED70 File Offset: 0x0028CF70
		// (set) Token: 0x0600A1A3 RID: 41379 RVA: 0x0004F105 File Offset: 0x0004D305
		public unsafe GameObject WideKeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x0028EDA0 File Offset: 0x0028CFA0
		// (set) Token: 0x0600A1A5 RID: 41381 RVA: 0x0004F124 File Offset: 0x0004D324
		public unsafe GameObject ExtraWideKeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x0028EDD0 File Offset: 0x0028CFD0
		// (set) Token: 0x0600A1A7 RID: 41383 RVA: 0x0004F143 File Offset: 0x0004D343
		public unsafe GameObject LeftClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600A1A8 RID: 41384 RVA: 0x0028EE00 File Offset: 0x0028D000
		// (set) Token: 0x0600A1A9 RID: 41385 RVA: 0x0004F162 File Offset: 0x0004D362
		public unsafe GameObject MiddleClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600A1AA RID: 41386 RVA: 0x0028EE30 File Offset: 0x0028D030
		// (set) Token: 0x0600A1AB RID: 41387 RVA: 0x0004F181 File Offset: 0x0004D381
		public unsafe GameObject RightClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C71 RID: 27761
		private static readonly IntPtr NativeFieldInfoPtr_KeyPromptPrefab;

		// Token: 0x04006C72 RID: 27762
		private static readonly IntPtr NativeFieldInfoPtr_WideKeyPromptPrefab;

		// Token: 0x04006C73 RID: 27763
		private static readonly IntPtr NativeFieldInfoPtr_ExtraWideKeyPromptPrefab;

		// Token: 0x04006C74 RID: 27764
		private static readonly IntPtr NativeFieldInfoPtr_LeftClickPromptPrefab;

		// Token: 0x04006C75 RID: 27765
		private static readonly IntPtr NativeFieldInfoPtr_MiddleClickPromptPrefab;

		// Token: 0x04006C76 RID: 27766
		private static readonly IntPtr NativeFieldInfoPtr_RightClickPromptPrefab;

		// Token: 0x04006C77 RID: 27767
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0;

		// Token: 0x04006C78 RID: 27768
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0;

		// Token: 0x04006C79 RID: 27769
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0;

		// Token: 0x04006C7A RID: 27770
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0;

		// Token: 0x04006C7B RID: 27771
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0;

		// Token: 0x04006C7C RID: 27772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
