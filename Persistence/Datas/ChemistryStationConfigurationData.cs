using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000290 RID: 656
	[Serializable]
	public class ChemistryStationConfigurationData : SaveData
	{
		// Token: 0x060030CA RID: 12490 RVA: 0x0010F79C File Offset: 0x0010D99C
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationConfigurationData()
		{
			Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistryStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr);
			ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, "Recipe");
			ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, "Destination");
			ChemistryStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, 100669021);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x0010F808 File Offset: 0x0010DA08
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationConfigurationData(StationRecipeFieldData recipe, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x00019962 File Offset: 0x00017B62
		public ChemistryStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x0010F868 File Offset: 0x0010DA68
		// (set) Token: 0x060030CE RID: 12494 RVA: 0x0001996B File Offset: 0x00017B6B
		public unsafe StationRecipeFieldData Recipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x0010F898 File Offset: 0x0010DA98
		// (set) Token: 0x060030D0 RID: 12496 RVA: 0x0001998A File Offset: 0x00017B8A
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeFieldInfoPtr_Recipe;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0;
	}
}
