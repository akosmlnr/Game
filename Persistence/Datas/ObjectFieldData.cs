using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000298 RID: 664
	[System.Serializable]
	public class ObjectFieldData : Il2CppSystem.Object
	{
		// Token: 0x060030FA RID: 12538 RVA: 0x0010FF80 File Offset: 0x0010E180
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectFieldData()
		{
			Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ObjectFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr);
			ObjectFieldData.NativeFieldInfoPtr_ObjectGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr, "ObjectGUID");
			ObjectFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr, 100669029);
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x0010FFD8 File Offset: 0x0010E1D8
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19232, RefRangeEnd = 19435, XrefRangeStart = 19232, XrefRangeEnd = 19435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldData(string objectGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectGUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x00019B1A File Offset: 0x00017D1A
		public ObjectFieldData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x00110024 File Offset: 0x0010E224
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x00019B23 File Offset: 0x00017D23
		public unsafe string ObjectGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldData.NativeFieldInfoPtr_ObjectGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldData.NativeFieldInfoPtr_ObjectGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400203A RID: 8250
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectGUID;

		// Token: 0x0400203B RID: 8251
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
