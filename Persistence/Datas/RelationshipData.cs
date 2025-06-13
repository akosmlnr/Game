using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs.Relation;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000285 RID: 645
	[Serializable]
	public class RelationshipData : SaveData
	{
		// Token: 0x06003082 RID: 12418 RVA: 0x0010EBA8 File Offset: 0x0010CDA8
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipData()
		{
			Il2CppClassPointerStore<RelationshipData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RelationshipData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr);
			RelationshipData.NativeFieldInfoPtr_RelationDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "RelationDelta");
			RelationshipData.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "Unlocked");
			RelationshipData.NativeFieldInfoPtr_UnlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "UnlockType");
			RelationshipData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, 100669009);
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x0010EC28 File Offset: 0x0010CE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136654, RefRangeEnd = 136655, XrefRangeStart = 136653, XrefRangeEnd = 136654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipData(float relationDelta, bool unlocked, NPCRelationData.EUnlockType unlockType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationDelta;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlocked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockType;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x00019699 File Offset: 0x00017899
		public RelationshipData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x0010EC8C File Offset: 0x0010CE8C
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x000196A2 File Offset: 0x000178A2
		public unsafe float RelationDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_RelationDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_RelationDelta)) = value;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x0010ECB4 File Offset: 0x0010CEB4
		// (set) Token: 0x06003088 RID: 12424 RVA: 0x000196BD File Offset: 0x000178BD
		public unsafe bool Unlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x0010ECDC File Offset: 0x0010CEDC
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x000196D8 File Offset: 0x000178D8
		public unsafe NPCRelationData.EUnlockType UnlockType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_UnlockType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_UnlockType)) = value;
			}
		}

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeFieldInfoPtr_RelationDelta;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeFieldInfoPtr_UnlockType;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0;
	}
}
