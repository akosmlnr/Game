using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E1 RID: 1761
	public class CauldronConfigPanel : ConfigPanel
	{
		// Token: 0x06009DD6 RID: 40406 RVA: 0x00282EB4 File Offset: 0x002810B4
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronConfigPanel()
		{
			Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CauldronConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr);
			CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, "DestinationUI");
			CauldronConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, 100682806);
			CauldronConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, 100682807);
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x00282F20 File Offset: 0x00281120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280243, XrefRangeEnd = 280278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x00282F70 File Offset: 0x00281170
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x0004D0FF File Offset: 0x0004B2FF
		public CauldronConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x06009DDA RID: 40410 RVA: 0x00282FAC File Offset: 0x002811AC
		// (set) Token: 0x06009DDB RID: 40411 RVA: 0x0004D108 File Offset: 0x0004B308
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A1F RID: 27167
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006A20 RID: 27168
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A21 RID: 27169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
