using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E5 RID: 1765
	public class DryingRackConfigPanel : ConfigPanel
	{
		// Token: 0x06009DF4 RID: 40436 RVA: 0x00283420 File Offset: 0x00281620
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfigPanel()
		{
			Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "DryingRackConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr);
			DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "QualityUI");
			DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "DestinationUI");
			DryingRackConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, 100682814);
			DryingRackConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, 100682815);
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x002834A0 File Offset: 0x002816A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280438, XrefRangeEnd = 280483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DF6 RID: 40438 RVA: 0x002834F0 File Offset: 0x002816F0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x0004D1FC File Offset: 0x0004B3FC
		public DryingRackConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x06009DF8 RID: 40440 RVA: 0x0028352C File Offset: 0x0028172C
		// (set) Token: 0x06009DF9 RID: 40441 RVA: 0x0004D205 File Offset: 0x0004B405
		public unsafe QualityFieldUI QualityUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x06009DFA RID: 40442 RVA: 0x0028355C File Offset: 0x0028175C
		// (set) Token: 0x06009DFB RID: 40443 RVA: 0x0004D224 File Offset: 0x0004B424
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A2E RID: 27182
		private static readonly IntPtr NativeFieldInfoPtr_QualityUI;

		// Token: 0x04006A2F RID: 27183
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006A30 RID: 27184
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A31 RID: 27185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
