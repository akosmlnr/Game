using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E7 RID: 1767
	public class MixingStationConfigPanel : ConfigPanel
	{
		// Token: 0x06009E02 RID: 40450 RVA: 0x002836B4 File Offset: 0x002818B4
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfigPanel()
		{
			Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MixingStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr);
			MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, "DestinationUI");
			MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, "StartThresholdUI");
			MixingStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, 100682818);
			MixingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, 100682819);
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x00283734 File Offset: 0x00281934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280518, XrefRangeEnd = 280563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x00283784 File Offset: 0x00281984
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x0004D26B File Offset: 0x0004B46B
		public MixingStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x06009E06 RID: 40454 RVA: 0x002837C0 File Offset: 0x002819C0
		// (set) Token: 0x06009E07 RID: 40455 RVA: 0x0004D274 File Offset: 0x0004B474
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x06009E08 RID: 40456 RVA: 0x002837F0 File Offset: 0x002819F0
		// (set) Token: 0x06009E09 RID: 40457 RVA: 0x0004D293 File Offset: 0x0004B493
		public unsafe NumberFieldUI StartThresholdUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A35 RID: 27189
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006A36 RID: 27190
		private static readonly IntPtr NativeFieldInfoPtr_StartThresholdUI;

		// Token: 0x04006A37 RID: 27191
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A38 RID: 27192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
