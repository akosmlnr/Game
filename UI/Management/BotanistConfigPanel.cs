using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DF RID: 1759
	public class BotanistConfigPanel : ConfigPanel
	{
		// Token: 0x06009DC6 RID: 40390 RVA: 0x00282BDC File Offset: 0x00280DDC
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfigPanel()
		{
			Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BotanistConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr);
			BotanistConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "BedUI");
			BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "SuppliesUI");
			BotanistConfigPanel.NativeFieldInfoPtr_PotsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "PotsUI");
			BotanistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, 100682802);
			BotanistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, 100682803);
		}

		// Token: 0x06009DC7 RID: 40391 RVA: 0x00282C70 File Offset: 0x00280E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280156, XrefRangeEnd = 280208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DC8 RID: 40392 RVA: 0x00282CC0 File Offset: 0x00280EC0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DC9 RID: 40393 RVA: 0x0004D071 File Offset: 0x0004B271
		public BotanistConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x06009DCA RID: 40394 RVA: 0x00282CFC File Offset: 0x00280EFC
		// (set) Token: 0x06009DCB RID: 40395 RVA: 0x0004D07A File Offset: 0x0004B27A
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x06009DCC RID: 40396 RVA: 0x00282D2C File Offset: 0x00280F2C
		// (set) Token: 0x06009DCD RID: 40397 RVA: 0x0004D099 File Offset: 0x0004B299
		public unsafe ObjectFieldUI SuppliesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x06009DCE RID: 40398 RVA: 0x00282D5C File Offset: 0x00280F5C
		// (set) Token: 0x06009DCF RID: 40399 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
		public unsafe ObjectListFieldUI PotsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_PotsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_PotsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A17 RID: 27159
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x04006A18 RID: 27160
		private static readonly IntPtr NativeFieldInfoPtr_SuppliesUI;

		// Token: 0x04006A19 RID: 27161
		private static readonly IntPtr NativeFieldInfoPtr_PotsUI;

		// Token: 0x04006A1A RID: 27162
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A1B RID: 27163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
