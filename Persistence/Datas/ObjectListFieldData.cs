using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000299 RID: 665
	[System.Serializable]
	public class ObjectListFieldData : Il2CppSystem.Object
	{
		// Token: 0x060030FF RID: 12543 RVA: 0x0011004C File Offset: 0x0010E24C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListFieldData()
		{
			Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ObjectListFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr);
			ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr, "ObjectGUIDs");
			ObjectListFieldData.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr, 100669030);
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x001100A4 File Offset: 0x0010E2A4
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19232, RefRangeEnd = 19435, XrefRangeStart = 19232, XrefRangeEnd = 19435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldData(List<string> objectGUIDs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectGUIDs);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldData.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x00019B42 File Offset: 0x00017D42
		public ObjectListFieldData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x001100F0 File Offset: 0x0010E2F0
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x00019B4B File Offset: 0x00017D4B
		public unsafe List<string> ObjectGUIDs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400203C RID: 8252
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectGUIDs;

		// Token: 0x0400203D RID: 8253
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;
	}
}
