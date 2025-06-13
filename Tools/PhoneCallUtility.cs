using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ScriptableObjects;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000567 RID: 1383
	public class PhoneCallUtility : MonoBehaviour
	{
		// Token: 0x0600796E RID: 31086 RVA: 0x00210C08 File Offset: 0x0020EE08
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallUtility()
		{
			Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PhoneCallUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr);
			PhoneCallUtility.NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678685);
			PhoneCallUtility.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678686);
			PhoneCallUtility.NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678687);
			PhoneCallUtility.NativeMethodInfoPtr_ClearCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678688);
			PhoneCallUtility.NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678689);
			PhoneCallUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678690);
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x00210CB0 File Offset: 0x0020EEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235423, XrefRangeEnd = 235429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PromptCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x00210CF4 File Offset: 0x0020EEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235429, XrefRangeEnd = 235435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x00210D38 File Offset: 0x0020EF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235435, XrefRangeEnd = 235441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQueuedCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007972 RID: 31090 RVA: 0x00210D7C File Offset: 0x0020EF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235441, XrefRangeEnd = 235447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_ClearCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x00210DB0 File Offset: 0x0020EFB0
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPhoneOpenable(bool openable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openable;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x00210DF0 File Offset: 0x0020EFF0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCallUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x00039456 File Offset: 0x00037656
		public PhoneCallUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040052E2 RID: 21218
		private static readonly IntPtr NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0;

		// Token: 0x040052E3 RID: 21219
		private static readonly IntPtr NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0;

		// Token: 0x040052E4 RID: 21220
		private static readonly IntPtr NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0;

		// Token: 0x040052E5 RID: 21221
		private static readonly IntPtr NativeMethodInfoPtr_ClearCall_Public_Void_0;

		// Token: 0x040052E6 RID: 21222
		private static readonly IntPtr NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0;

		// Token: 0x040052E7 RID: 21223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
