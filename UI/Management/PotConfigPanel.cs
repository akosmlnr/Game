using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006EA RID: 1770
	public class PotConfigPanel : ConfigPanel
	{
		// Token: 0x06009E1A RID: 40474 RVA: 0x00283AF8 File Offset: 0x00281CF8
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfigPanel()
		{
			Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PotConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr);
			PotConfigPanel.NativeFieldInfoPtr_SeedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "SeedUI");
			PotConfigPanel.NativeFieldInfoPtr_Additive1UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive1UI");
			PotConfigPanel.NativeFieldInfoPtr_Additive2UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive2UI");
			PotConfigPanel.NativeFieldInfoPtr_Additive3UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive3UI");
			PotConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "DestinationUI");
			PotConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, 100682824);
			PotConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, 100682825);
		}

		// Token: 0x06009E1B RID: 40475 RVA: 0x00283BB4 File Offset: 0x00281DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280653, XrefRangeEnd = 280728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E1C RID: 40476 RVA: 0x00283C04 File Offset: 0x00281E04
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E1D RID: 40477 RVA: 0x0004D340 File Offset: 0x0004B540
		public PotConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x06009E1E RID: 40478 RVA: 0x00283C40 File Offset: 0x00281E40
		// (set) Token: 0x06009E1F RID: 40479 RVA: 0x0004D349 File Offset: 0x0004B549
		public unsafe ItemFieldUI SeedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_SeedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_SeedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x06009E20 RID: 40480 RVA: 0x00283C70 File Offset: 0x00281E70
		// (set) Token: 0x06009E21 RID: 40481 RVA: 0x0004D368 File Offset: 0x0004B568
		public unsafe ItemFieldUI Additive1UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive1UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive1UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x06009E22 RID: 40482 RVA: 0x00283CA0 File Offset: 0x00281EA0
		// (set) Token: 0x06009E23 RID: 40483 RVA: 0x0004D387 File Offset: 0x0004B587
		public unsafe ItemFieldUI Additive2UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive2UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive2UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x06009E24 RID: 40484 RVA: 0x00283CD0 File Offset: 0x00281ED0
		// (set) Token: 0x06009E25 RID: 40485 RVA: 0x0004D3A6 File Offset: 0x0004B5A6
		public unsafe ItemFieldUI Additive3UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive3UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive3UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x06009E26 RID: 40486 RVA: 0x00283D00 File Offset: 0x00281F00
		// (set) Token: 0x06009E27 RID: 40487 RVA: 0x0004D3C5 File Offset: 0x0004B5C5
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A41 RID: 27201
		private static readonly IntPtr NativeFieldInfoPtr_SeedUI;

		// Token: 0x04006A42 RID: 27202
		private static readonly IntPtr NativeFieldInfoPtr_Additive1UI;

		// Token: 0x04006A43 RID: 27203
		private static readonly IntPtr NativeFieldInfoPtr_Additive2UI;

		// Token: 0x04006A44 RID: 27204
		private static readonly IntPtr NativeFieldInfoPtr_Additive3UI;

		// Token: 0x04006A45 RID: 27205
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006A46 RID: 27206
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A47 RID: 27207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
