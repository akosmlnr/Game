using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020004AB RID: 1195
	public class ConstructStart_OutdoorGrid : ConstructStart_Base
	{
		// Token: 0x0600669C RID: 26268 RVA: 0x001D1B64 File Offset: 0x001CFD64
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStart_OutdoorGrid()
		{
			Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStart_OutdoorGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr);
			ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, "constructable");
			ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, "ghostModel");
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676391);
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676392);
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676393);
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x001D1BF8 File Offset: 0x001CFDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208997, XrefRangeEnd = 209025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(constructableID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(movedConstructable);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructStart_OutdoorGrid.NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x001D1C58 File Offset: 0x001CFE58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209071, RefRangeEnd = 209072, XrefRangeStart = 209025, XrefRangeEnd = 209071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGhostModel(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_OutdoorGrid.NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x001D1C9C File Offset: 0x001CFE9C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStart_OutdoorGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x00030472 File Offset: 0x0002E672
		public ConstructStart_OutdoorGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x060066A1 RID: 26273 RVA: 0x001D1CD8 File Offset: 0x001CFED8
		// (set) Token: 0x060066A2 RID: 26274 RVA: 0x0003047B File Offset: 0x0002E67B
		public unsafe Constructable_GridBased constructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x060066A3 RID: 26275 RVA: 0x001D1D08 File Offset: 0x001CFF08
		// (set) Token: 0x060066A4 RID: 26276 RVA: 0x0003049A File Offset: 0x0002E69A
		public unsafe Transform ghostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004607 RID: 17927
		private static readonly IntPtr NativeFieldInfoPtr_constructable;

		// Token: 0x04004608 RID: 17928
		private static readonly IntPtr NativeFieldInfoPtr_ghostModel;

		// Token: 0x04004609 RID: 17929
		private static readonly IntPtr NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0;

		// Token: 0x0400460A RID: 17930
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0;

		// Token: 0x0400460B RID: 17931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
