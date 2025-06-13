using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002DF RID: 735
	[Serializable]
	public class WorldStorageEntitiesData : SaveData
	{
		// Token: 0x0600337C RID: 13180 RVA: 0x00117190 File Offset: 0x00115390
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntitiesData()
		{
			Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WorldStorageEntitiesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr);
			WorldStorageEntitiesData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr, "Entities");
			WorldStorageEntitiesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr, 100669109);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x001171E8 File Offset: 0x001153E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntitiesData(Il2CppReferenceArray<WorldStorageEntityData> entities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntitiesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x0001B5F6 File Offset: 0x000197F6
		public WorldStorageEntitiesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x0600337F RID: 13183 RVA: 0x00117234 File Offset: 0x00115434
		// (set) Token: 0x06003380 RID: 13184 RVA: 0x0001B5FF File Offset: 0x000197FF
		public unsafe Il2CppReferenceArray<WorldStorageEntityData> Entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntitiesData.NativeFieldInfoPtr_Entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WorldStorageEntityData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntitiesData.NativeFieldInfoPtr_Entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeFieldInfoPtr_Entities;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0;
	}
}
