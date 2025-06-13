using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003B1 RID: 945
	public static class ConfigurableType : Il2CppSystem.Object
	{
		// Token: 0x0600493B RID: 18747 RVA: 0x000233DC File Offset: 0x000215DC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurableType()
		{
			Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigurableType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr);
			ConfigurableType.NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr, 100672429);
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x0016809C File Offset: 0x0016629C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165899, RefRangeEnd = 165901, XrefRangeStart = 165882, XrefRangeEnd = 165899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeName(EConfigurableType type)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ConfigurableType.NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x00023415 File Offset: 0x00021615
		public ConfigurableType(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003155 RID: 12629
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0;
	}
}
