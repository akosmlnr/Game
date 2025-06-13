using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E2 RID: 1762
	public class ChemistConfigPanel : ConfigPanel
	{
		// Token: 0x06009DDC RID: 40412 RVA: 0x00282FDC File Offset: 0x002811DC
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfigPanel()
		{
			Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr);
			ChemistConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, "BedUI");
			ChemistConfigPanel.NativeFieldInfoPtr_StationsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, "StationsUI");
			ChemistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, 100682808);
			ChemistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, 100682809);
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x0028305C File Offset: 0x0028125C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280278, XrefRangeEnd = 280323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DDE RID: 40414 RVA: 0x002830AC File Offset: 0x002812AC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DDF RID: 40415 RVA: 0x0004D127 File Offset: 0x0004B327
		public ChemistConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x002830E8 File Offset: 0x002812E8
		// (set) Token: 0x06009DE1 RID: 40417 RVA: 0x0004D130 File Offset: 0x0004B330
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x06009DE2 RID: 40418 RVA: 0x00283118 File Offset: 0x00281318
		// (set) Token: 0x06009DE3 RID: 40419 RVA: 0x0004D14F File Offset: 0x0004B34F
		public unsafe ObjectListFieldUI StationsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_StationsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_StationsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A22 RID: 27170
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x04006A23 RID: 27171
		private static readonly IntPtr NativeFieldInfoPtr_StationsUI;

		// Token: 0x04006A24 RID: 27172
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A25 RID: 27173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
