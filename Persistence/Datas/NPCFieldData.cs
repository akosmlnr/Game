using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000296 RID: 662
	[System.Serializable]
	public class NPCFieldData : Il2CppSystem.Object
	{
		// Token: 0x060030F0 RID: 12528 RVA: 0x0010FDEC File Offset: 0x0010DFEC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCFieldData()
		{
			Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr);
			NPCFieldData.NativeFieldInfoPtr_NPCGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr, "NPCGuid");
			NPCFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr, 100669027);
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0010FE44 File Offset: 0x0010E044
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19232, RefRangeEnd = 19435, XrefRangeStart = 19232, XrefRangeEnd = 19435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldData(string npcGuid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcGuid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x00019ACE File Offset: 0x00017CCE
		public NPCFieldData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x060030F3 RID: 12531 RVA: 0x0010FE90 File Offset: 0x0010E090
		// (set) Token: 0x060030F4 RID: 12532 RVA: 0x00019AD7 File Offset: 0x00017CD7
		public unsafe string NPCGuid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldData.NativeFieldInfoPtr_NPCGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldData.NativeFieldInfoPtr_NPCGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002036 RID: 8246
		private static readonly System.IntPtr NativeFieldInfoPtr_NPCGuid;

		// Token: 0x04002037 RID: 8247
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
