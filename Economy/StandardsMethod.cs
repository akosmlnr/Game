using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200043A RID: 1082
	public static class StandardsMethod : Il2CppSystem.Object
	{
		// Token: 0x06005D93 RID: 23955 RVA: 0x001B368C File Offset: 0x001B188C
		// Note: this type is marked as 'beforefieldinit'.
		static StandardsMethod()
		{
			Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "StandardsMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr);
			StandardsMethod.NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr, 100675310);
			StandardsMethod.NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr, 100675311);
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x001B36E4 File Offset: 0x001B18E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197838, RefRangeEnd = 197839, XrefRangeStart = 197831, XrefRangeEnd = 197838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this ECustomerStandard property)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref property;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StandardsMethod.NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x001B371C File Offset: 0x001B191C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 197839, RefRangeEnd = 197847, XrefRangeStart = 197839, XrefRangeEnd = 197839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality GetCorrespondingQuality(this ECustomerStandard property)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref property;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StandardsMethod.NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x0002BEC4 File Offset: 0x0002A0C4
		public StandardsMethod(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004000 RID: 16384
		private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0;

		// Token: 0x04004001 RID: 16385
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0;
	}
}
