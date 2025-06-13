using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E0 RID: 1760
	public class BrickPressConfigPanel : ConfigPanel
	{
		// Token: 0x06009DD0 RID: 40400 RVA: 0x00282D8C File Offset: 0x00280F8C
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressConfigPanel()
		{
			Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BrickPressConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr);
			BrickPressConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr, "DestinationUI");
			BrickPressConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr, 100682804);
			BrickPressConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr, 100682805);
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x00282DF8 File Offset: 0x00280FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280208, XrefRangeEnd = 280243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DD2 RID: 40402 RVA: 0x00282E48 File Offset: 0x00281048
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DD3 RID: 40403 RVA: 0x0004D0D7 File Offset: 0x0004B2D7
		public BrickPressConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x06009DD4 RID: 40404 RVA: 0x00282E84 File Offset: 0x00281084
		// (set) Token: 0x06009DD5 RID: 40405 RVA: 0x0004D0E0 File Offset: 0x0004B2E0
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A1C RID: 27164
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006A1D RID: 27165
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A1E RID: 27166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
