using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management.UI
{
	// Token: 0x020003C9 RID: 969
	public class ConfigPanel : MonoBehaviour
	{
		// Token: 0x06004AC4 RID: 19140 RVA: 0x0016DCEC File Offset: 0x0016BEEC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigPanel()
		{
			Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.UI", "ConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr);
			ConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100672645);
			ConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100672646);
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x0016DD44 File Offset: 0x0016BF44
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x0016DD94 File Offset: 0x0016BF94
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00023D99 File Offset: 0x00021F99
		public ConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003268 RID: 12904
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0;

		// Token: 0x04003269 RID: 12905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
