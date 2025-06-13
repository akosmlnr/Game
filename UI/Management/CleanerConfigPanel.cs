using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E4 RID: 1764
	public class CleanerConfigPanel : ConfigPanel
	{
		// Token: 0x06009DEC RID: 40428 RVA: 0x002832B4 File Offset: 0x002814B4
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfigPanel()
		{
			Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CleanerConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr);
			CleanerConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, "BedUI");
			CleanerConfigPanel.NativeFieldInfoPtr_BinsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, "BinsUI");
			CleanerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, 100682812);
			CleanerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, 100682813);
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x00283334 File Offset: 0x00281534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280393, XrefRangeEnd = 280438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x00283384 File Offset: 0x00281584
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x0004D1B5 File Offset: 0x0004B3B5
		public CleanerConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x06009DF0 RID: 40432 RVA: 0x002833C0 File Offset: 0x002815C0
		// (set) Token: 0x06009DF1 RID: 40433 RVA: 0x0004D1BE File Offset: 0x0004B3BE
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x06009DF2 RID: 40434 RVA: 0x002833F0 File Offset: 0x002815F0
		// (set) Token: 0x06009DF3 RID: 40435 RVA: 0x0004D1DD File Offset: 0x0004B3DD
		public unsafe ObjectListFieldUI BinsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BinsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BinsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A2A RID: 27178
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x04006A2B RID: 27179
		private static readonly IntPtr NativeFieldInfoPtr_BinsUI;

		// Token: 0x04006A2C RID: 27180
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A2D RID: 27181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
