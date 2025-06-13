using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020004AA RID: 1194
	public class ConstructStart_Base : MonoBehaviour
	{
		// Token: 0x06006698 RID: 26264 RVA: 0x001D1A70 File Offset: 0x001CFC70
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStart_Base()
		{
			Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStart_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr);
			ConstructStart_Base.NativeMethodInfoPtr_StartConstruction_Public_Virtual_New_Void_String_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr, 100676389);
			ConstructStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr, 100676390);
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x001D1AC8 File Offset: 0x001CFCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208988, XrefRangeEnd = 208997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(constructableID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(movedConstructable);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructStart_Base.NativeMethodInfoPtr_StartConstruction_Public_Virtual_New_Void_String_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x001D1B28 File Offset: 0x001CFD28
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStart_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x00030469 File Offset: 0x0002E669
		public ConstructStart_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004605 RID: 17925
		private static readonly IntPtr NativeMethodInfoPtr_StartConstruction_Public_Virtual_New_Void_String_Constructable_GridBased_0;

		// Token: 0x04004606 RID: 17926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
