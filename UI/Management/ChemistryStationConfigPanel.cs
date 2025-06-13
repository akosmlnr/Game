using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E3 RID: 1763
	public class ChemistryStationConfigPanel : ConfigPanel
	{
		// Token: 0x06009DE4 RID: 40420 RVA: 0x00283148 File Offset: 0x00281348
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationConfigPanel()
		{
			Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistryStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr);
			ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, "RecipeUI");
			ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, "DestinationUI");
			ChemistryStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, 100682810);
			ChemistryStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, 100682811);
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x002831C8 File Offset: 0x002813C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280323, XrefRangeEnd = 280393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x00283218 File Offset: 0x00281418
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE7 RID: 40423 RVA: 0x0004D16E File Offset: 0x0004B36E
		public ChemistryStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x06009DE8 RID: 40424 RVA: 0x00283254 File Offset: 0x00281454
		// (set) Token: 0x06009DE9 RID: 40425 RVA: 0x0004D177 File Offset: 0x0004B377
		public unsafe StationRecipeFieldUI RecipeUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x06009DEA RID: 40426 RVA: 0x00283284 File Offset: 0x00281484
		// (set) Token: 0x06009DEB RID: 40427 RVA: 0x0004D196 File Offset: 0x0004B396
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A26 RID: 27174
		private static readonly IntPtr NativeFieldInfoPtr_RecipeUI;

		// Token: 0x04006A27 RID: 27175
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006A28 RID: 27176
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006A29 RID: 27177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
