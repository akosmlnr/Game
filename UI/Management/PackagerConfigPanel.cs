using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E8 RID: 1768
	public class PackagerConfigPanel : ConfigPanel
	{
		// Token: 0x06009E0A RID: 40458 RVA: 0x00283820 File Offset: 0x00281A20
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerConfigPanel()
		{
			Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagerConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr);
			PackagerConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "BedUI");
			PackagerConfigPanel.NativeFieldInfoPtr_StationsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "StationsUI");
			PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "RoutesUI");
			PackagerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, 100682820);
			PackagerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, 100682821);
		}

		// Token: 0x06009E0B RID: 40459 RVA: 0x002838B4 File Offset: 0x00281AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280563, XrefRangeEnd = 280618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x00283904 File Offset: 0x00281B04
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x0004D2B2 File Offset: 0x0004B4B2
		public PackagerConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x06009E0E RID: 40462 RVA: 0x00283940 File Offset: 0x00281B40
		// (set) Token: 0x06009E0F RID: 40463 RVA: 0x0004D2BB File Offset: 0x0004B4BB
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x06009E10 RID: 40464 RVA: 0x00283970 File Offset: 0x00281B70
		// (set) Token: 0x06009E11 RID: 40465 RVA: 0x0004D2DA File Offset: 0x0004B4DA
		public unsafe ObjectListFieldUI StationsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_StationsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_StationsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x06009E12 RID: 40466 RVA: 0x002839A0 File Offset: 0x00281BA0
		// (set) Token: 0x06009E13 RID: 40467 RVA: 0x0004D2F9 File Offset: 0x0004B4F9
		public unsafe RouteListFieldUI RoutesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A39 RID: 27193
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x04006A3A RID: 27194
		private static readonly IntPtr NativeFieldInfoPtr_StationsUI;

		// Token: 0x04006A3B RID: 27195
		private static readonly IntPtr NativeFieldInfoPtr_RoutesUI;

		// Token: 0x04006A3C RID: 27196
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A3D RID: 27197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
