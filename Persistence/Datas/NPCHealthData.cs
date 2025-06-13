using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A5 RID: 677
	public class NPCHealthData : SaveData
	{
		// Token: 0x0600315E RID: 12638 RVA: 0x00110FBC File Offset: 0x0010F1BC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCHealthData()
		{
			Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCHealthData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr);
			NPCHealthData.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "Health");
			NPCHealthData.NativeFieldInfoPtr_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "IsDead");
			NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "DaysPassedSinceDeath");
			NPCHealthData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, 100669043);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0011103C File Offset: 0x0010F23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136654, RefRangeEnd = 136655, XrefRangeStart = 136654, XrefRangeEnd = 136655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCHealthData(float health, bool isDead, int daysPassedSinceDeath) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref health;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daysPassedSinceDeath;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealthData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00019F0D File Offset: 0x0001810D
		public NPCHealthData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x001110A0 File Offset: 0x0010F2A0
		// (set) Token: 0x06003162 RID: 12642 RVA: 0x00019F16 File Offset: 0x00018116
		public unsafe float Health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_Health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_Health)) = value;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06003163 RID: 12643 RVA: 0x001110C8 File Offset: 0x0010F2C8
		// (set) Token: 0x06003164 RID: 12644 RVA: 0x00019F31 File Offset: 0x00018131
		public unsafe bool IsDead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_IsDead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_IsDead)) = value;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06003165 RID: 12645 RVA: 0x001110F0 File Offset: 0x0010F2F0
		// (set) Token: 0x06003166 RID: 12646 RVA: 0x00019F4C File Offset: 0x0001814C
		public unsafe int DaysPassedSinceDeath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath)) = value;
			}
		}

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeFieldInfoPtr_Health;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeFieldInfoPtr_IsDead;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeFieldInfoPtr_DaysPassedSinceDeath;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0;
	}
}
