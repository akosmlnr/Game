using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002DC RID: 732
	[Serializable]
	public class VariableData : SaveData
	{
		// Token: 0x06003360 RID: 13152 RVA: 0x00116D04 File Offset: 0x00114F04
		// Note: this type is marked as 'beforefieldinit'.
		static VariableData()
		{
			Il2CppClassPointerStore<VariableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VariableData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableData>.NativeClassPtr);
			VariableData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableData>.NativeClassPtr, "Name");
			VariableData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableData>.NativeClassPtr, "Value");
			VariableData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableData>.NativeClassPtr, 100669105);
			VariableData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableData>.NativeClassPtr, 100669106);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x00116D84 File Offset: 0x00114F84
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableData(string name, string value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00116DE4 File Offset: 0x00114FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137278, RefRangeEnd = 137279, XrefRangeStart = 137270, XrefRangeEnd = 137278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x0001B4CC File Offset: 0x000196CC
		public VariableData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06003364 RID: 13156 RVA: 0x00116E20 File Offset: 0x00115020
		// (set) Token: 0x06003365 RID: 13157 RVA: 0x0001B4D5 File Offset: 0x000196D5
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06003366 RID: 13158 RVA: 0x00116E48 File Offset: 0x00115048
		// (set) Token: 0x06003367 RID: 13159 RVA: 0x0001B4F4 File Offset: 0x000196F4
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
