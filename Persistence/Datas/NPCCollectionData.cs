using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A3 RID: 675
	public class NPCCollectionData : SaveData
	{
		// Token: 0x06003154 RID: 12628 RVA: 0x00110E1C File Offset: 0x0010F01C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCCollectionData()
		{
			Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCCollectionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr);
			NPCCollectionData.NativeFieldInfoPtr_NPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr, "NPCs");
			NPCCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr, 100669041);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00110E74 File Offset: 0x0010F074
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCCollectionData(Il2CppReferenceArray<DynamicSaveData> npcs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DynamicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x00019EBD File Offset: 0x000180BD
		public NPCCollectionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x00110EC0 File Offset: 0x0010F0C0
		// (set) Token: 0x06003158 RID: 12632 RVA: 0x00019EC6 File Offset: 0x000180C6
		public unsafe Il2CppReferenceArray<DynamicSaveData> NPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCCollectionData.NativeFieldInfoPtr_NPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCCollectionData.NativeFieldInfoPtr_NPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeFieldInfoPtr_NPCs;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DynamicSaveData_0;
	}
}
