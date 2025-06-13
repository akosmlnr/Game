using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000278 RID: 632
	public class GameData : SaveData
	{
		// Token: 0x0600302D RID: 12333 RVA: 0x0010DB80 File Offset: 0x0010BD80
		// Note: this type is marked as 'beforefieldinit'.
		static GameData()
		{
			Il2CppClassPointerStore<GameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameData>.NativeClassPtr);
			GameData.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "OrganisationName");
			GameData.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "Seed");
			GameData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "Settings");
			GameData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameData>.NativeClassPtr, 100668974);
			GameData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameData>.NativeClassPtr, 100668975);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x0010DC14 File Offset: 0x0010BE14
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136480, RefRangeEnd = 136486, XrefRangeStart = 136477, XrefRangeEnd = 136480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameData(string organisationName, int seed, GameSettings settings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(organisationName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x0010DC80 File Offset: 0x0010BE80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136491, RefRangeEnd = 136492, XrefRangeStart = 136486, XrefRangeEnd = 136491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x00019367 File Offset: 0x00017567
		public GameData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x0010DCBC File Offset: 0x0010BEBC
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00019370 File Offset: 0x00017570
		public unsafe string OrganisationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x0010DCE4 File Offset: 0x0010BEE4
		// (set) Token: 0x06003034 RID: 12340 RVA: 0x0001938F File Offset: 0x0001758F
		public unsafe int Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Seed)) = value;
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x0010DD0C File Offset: 0x0010BF0C
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x000193AA File Offset: 0x000175AA
		public unsafe GameSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
